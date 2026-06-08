USE DeepCreekDB;
GO

IF OBJECT_ID('dbo.QualityDefect', 'U') IS NOT NULL
    DROP TABLE dbo.QualityDefect;
GO

IF OBJECT_ID('dbo.QualityInspection', 'U') IS NOT NULL
    DROP TABLE dbo.QualityInspection;
GO

CREATE TABLE dbo.QualityInspection
(
    InspectionID INT IDENTITY(1,1) PRIMARY KEY,
    BatchID INT NOT NULL,
    InspectionDate DATE NOT NULL,

    CONSTRAINT FK_QualityInspection_ProductionBatch
        FOREIGN KEY (BatchID)
        REFERENCES dbo.ProductionBatch(BatchID)
);
GO

CREATE TABLE dbo.QualityDefect
(
    DefectID INT IDENTITY(1,1) PRIMARY KEY,
    InspectionID INT NOT NULL,
    UnitNumber INT NOT NULL,
    DefectCode VARCHAR(10) NOT NULL,
    SeverityCode VARCHAR(10) NOT NULL,
    ZoneCode VARCHAR(20) NULL,
    Comments VARCHAR(255) NULL,

    CONSTRAINT FK_QualityDefect_QualityInspection
        FOREIGN KEY (InspectionID)
        REFERENCES dbo.QualityInspection(InspectionID)
);
GO