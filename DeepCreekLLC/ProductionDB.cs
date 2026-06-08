using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace DeepCreekLLC.Database
{
    public class ProductionBatch
    {
        public int BatchID { get; set; }
        public string BatchCode { get; set; } = "";
        public DateTime BatchDate { get; set; }
        public int ProductionLineNumber { get; set; }
        public int ShiftNumber { get; set; }
        public string ModelCode { get; set; } = "";
        public int RodModelID { get; set; }
        public int PlannedQty { get; set; }
        public int ActualQty { get; set; }
        public int GoodUnits { get; set; }
        public int DefectUnits { get; set; }
    }

    public class RodModelItem
    {
        public int RodModelID { get; set; }
        public string DisplayText { get; set; } = "";

        public override string ToString()
        {
            return DisplayText;
        }
    }

    public static class ProductionRepository
    {
        public static List<ProductionBatch> GetAllBatches()
        {
            var list = new List<ProductionBatch>();

            const string sql = @"
                SELECT 
                    pb.BatchID, 
                    pb.BatchCode, 
                    pb.BatchDate,
                    pb.ProductionLineNumber, 
                    pb.ShiftNumber,
                    rm.ModelCode, 
                    pb.RodModelID,
                    pb.PlannedQty, 
                    pb.ActualQty, 
                    pb.GoodUnits, 
                    pb.DefectUnits
                FROM ProductionBatch pb
                JOIN RodModel rm 
                    ON rm.RodModelID = pb.RodModelID
                ORDER BY pb.BatchDate DESC, pb.BatchID DESC;";

            using var conn = DbConfig.GetConnection();
            using var cmd = new SqlCommand(sql, conn);

            conn.Open();

            using var rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                list.Add(new ProductionBatch
                {
                    BatchID = rdr.GetInt32(0),
                    BatchCode = rdr.GetString(1),
                    BatchDate = rdr.GetDateTime(2),
                    ProductionLineNumber = rdr.GetInt32(3),
                    ShiftNumber = rdr.GetInt32(4),
                    ModelCode = rdr.GetString(5),
                    RodModelID = rdr.GetInt32(6),
                    PlannedQty = rdr.GetInt32(7),
                    ActualQty = rdr.GetInt32(8),
                    GoodUnits = rdr.GetInt32(9),
                    DefectUnits = rdr.GetInt32(10)
                });
            }

            return list;
        }

        public static List<RodModelItem> GetRodModels()
        {
            var list = new List<RodModelItem>();

            const string sql = @"
                SELECT 
                    RodModelID,
                    ModelCode + ' - ' + Category + ' ' +
                    CAST(LengthFeet AS VARCHAR) + ''' ' + ActionCode AS DisplayText
                FROM RodModel
                ORDER BY Category, ModelCode;";

            using var conn = DbConfig.GetConnection();
            using var cmd = new SqlCommand(sql, conn);

            conn.Open();

            using var rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                list.Add(new RodModelItem
                {
                    RodModelID = rdr.GetInt32(0),
                    DisplayText = rdr.GetString(1)
                });
            }

            return list;
        }

        public static void InsertBatch(ProductionBatch b)
        {
            const string sql = @"
                INSERT INTO ProductionBatch
                    (
                        BatchCode, 
                        BatchDate, 
                        ProductionLineNumber, 
                        ShiftNumber,
                        RodModelID, 
                        PlannedQty, 
                        ActualQty, 
                        GoodUnits, 
                        DefectUnits
                    )
                VALUES
                    (
                        @BatchCode, 
                        @BatchDate, 
                        @Line, 
                        @Shift,
                        @RodModelID, 
                        @Planned, 
                        @Actual, 
                        @Good, 
                        @Defect
                    );";

            using var conn = DbConfig.GetConnection();
            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@BatchCode", b.BatchCode);
            cmd.Parameters.AddWithValue("@BatchDate", b.BatchDate);
            cmd.Parameters.AddWithValue("@Line", b.ProductionLineNumber);
            cmd.Parameters.AddWithValue("@Shift", b.ShiftNumber);
            cmd.Parameters.AddWithValue("@RodModelID", b.RodModelID);
            cmd.Parameters.AddWithValue("@Planned", b.PlannedQty);
            cmd.Parameters.AddWithValue("@Actual", b.ActualQty);
            cmd.Parameters.AddWithValue("@Good", b.GoodUnits);
            cmd.Parameters.AddWithValue("@Defect", b.DefectUnits);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public static void UpdateBatch(ProductionBatch b)
        {
            const string sql = @"
                UPDATE ProductionBatch 
                SET
                    BatchCode = @BatchCode,
                    BatchDate = @BatchDate,
                    ProductionLineNumber = @Line,
                    ShiftNumber = @Shift,
                    RodModelID = @RodModelID,
                    PlannedQty = @Planned,
                    ActualQty = @Actual,
                    GoodUnits = @Good,
                    DefectUnits = @Defect
                WHERE BatchID = @BatchID;";

            using var conn = DbConfig.GetConnection();
            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@BatchCode", b.BatchCode);
            cmd.Parameters.AddWithValue("@BatchDate", b.BatchDate);
            cmd.Parameters.AddWithValue("@Line", b.ProductionLineNumber);
            cmd.Parameters.AddWithValue("@Shift", b.ShiftNumber);
            cmd.Parameters.AddWithValue("@RodModelID", b.RodModelID);
            cmd.Parameters.AddWithValue("@Planned", b.PlannedQty);
            cmd.Parameters.AddWithValue("@Actual", b.ActualQty);
            cmd.Parameters.AddWithValue("@Good", b.GoodUnits);
            cmd.Parameters.AddWithValue("@Defect", b.DefectUnits);
            cmd.Parameters.AddWithValue("@BatchID", b.BatchID);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public static void DeleteBatch(int batchID)
        {
            const string sql = @"
                DELETE FROM ProductionBatch 
                WHERE BatchID = @BatchID;";

            using var conn = DbConfig.GetConnection();
            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@BatchID", batchID);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}