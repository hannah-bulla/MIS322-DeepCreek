using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace DeepCreekLLC.Database
{
    public class QualityDefect
    {
        public int DefectID { get; set; }
        public int BatchID { get; set; }
        public string BatchCode { get; set; } = "";
        public DateTime InspectionDate { get; set; }
        public int UnitNumber { get; set; }
        public string DefectCode { get; set; } = "";
        public string SeverityCode { get; set; } = "";
        public string ZoneCode { get; set; } = "";
        public string Comments { get; set; } = "";
    }

    public class BatchItem
    {
        public int BatchID { get; set; }
        public string DisplayText { get; set; } = "";

        public override string ToString()
        {
            return DisplayText;
        }
    }

    public static class QualityRepository
    {
        public static List<BatchItem> GetBatches()
        {
            var list = new List<BatchItem>();

            const string sql = @"
                SELECT pb.BatchID,
                       pb.BatchCode + ' - ' + rm.ModelCode AS DisplayText
                FROM ProductionBatch pb
                JOIN RodModel rm ON rm.RodModelID = pb.RodModelID
                ORDER BY pb.BatchDate DESC, pb.BatchID DESC;";

            using var conn = DbConfig.GetConnection();
            using var cmd = new SqlCommand(sql, conn);

            conn.Open();
            using var rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                list.Add(new BatchItem
                {
                    BatchID = rdr.GetInt32(0),
                    DisplayText = rdr.GetString(1)
                });
            }

            return list;
        }

        public static List<QualityDefect> GetAllDefects()
        {
            var list = new List<QualityDefect>();

            const string sql = @"
                SELECT 
                    qd.DefectID,
                    qi.BatchID,
                    pb.BatchCode,
                    qi.InspectionDate,
                    qd.UnitNumber,
                    qd.DefectCode,
                    qd.SeverityCode,
                    qd.ZoneCode,
                    qd.Comments
                FROM QualityDefect qd
                JOIN QualityInspection qi ON qi.InspectionID = qd.InspectionID
                JOIN ProductionBatch pb ON pb.BatchID = qi.BatchID
                ORDER BY qi.InspectionDate DESC, qd.DefectID DESC;";

            using var conn = DbConfig.GetConnection();
            using var cmd = new SqlCommand(sql, conn);

            conn.Open();
            using var rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                list.Add(new QualityDefect
                {
                    DefectID = rdr.GetInt32(0),
                    BatchID = rdr.GetInt32(1),
                    BatchCode = rdr.GetString(2),
                    InspectionDate = rdr.GetDateTime(3),
                    UnitNumber = rdr.GetInt32(4),
                    DefectCode = rdr.GetString(5),
                    SeverityCode = rdr.GetString(6),
                    ZoneCode = rdr.IsDBNull(7) ? "" : rdr.GetString(7),
                    Comments = rdr.IsDBNull(8) ? "" : rdr.GetString(8)
                });
            }

            return list;
        }

        public static void InsertDefect(QualityDefect d)
        {
            const string sql = @"
                DECLARE @InspectionID INT;

                SELECT @InspectionID = InspectionID
                FROM QualityInspection
                WHERE BatchID = @BatchID
                  AND InspectionDate = @InspectionDate;

                IF @InspectionID IS NULL
                BEGIN
                    INSERT INTO QualityInspection (BatchID, InspectionDate)
                    VALUES (@BatchID, @InspectionDate);

                    SET @InspectionID = SCOPE_IDENTITY();
                END

                INSERT INTO QualityDefect
                    (InspectionID, UnitNumber, DefectCode, SeverityCode, ZoneCode, Comments)
                VALUES
                    (@InspectionID, @UnitNumber, @DefectCode, @SeverityCode, @ZoneCode, @Comments);";

            using var conn = DbConfig.GetConnection();
            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@BatchID", d.BatchID);
            cmd.Parameters.AddWithValue("@InspectionDate", d.InspectionDate.Date);
            cmd.Parameters.AddWithValue("@UnitNumber", d.UnitNumber);
            cmd.Parameters.AddWithValue("@DefectCode", d.DefectCode);
            cmd.Parameters.AddWithValue("@SeverityCode", d.SeverityCode);
            cmd.Parameters.AddWithValue("@ZoneCode", string.IsNullOrWhiteSpace(d.ZoneCode) ? DBNull.Value : d.ZoneCode);
            cmd.Parameters.AddWithValue("@Comments", string.IsNullOrWhiteSpace(d.Comments) ? DBNull.Value : d.Comments);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public static void DeleteDefect(int defectID)
        {
            const string sql = "DELETE FROM QualityDefect WHERE DefectID = @DefectID;";

            using var conn = DbConfig.GetConnection();
            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@DefectID", defectID);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}