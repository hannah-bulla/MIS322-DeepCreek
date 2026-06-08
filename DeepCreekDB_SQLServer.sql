--  DeepCreekDB  –  SQL Server (T-SQL) version

-- Create and select the database
IF DB_ID('DeepCreekDB') IS NOT NULL
BEGIN
    ALTER DATABASE DeepCreekDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE DeepCreekDB;
END
GO

CREATE DATABASE DeepCreekDB;
GO

USE DeepCreekDB;
GO

--  Tables

CREATE TABLE RodModel (
    RodModelID   INT           IDENTITY(1,1) PRIMARY KEY,
    ModelCode    VARCHAR(50),
    ActionCode   VARCHAR(1),
    LengthFeet   DECIMAL(5,2),
    Category     VARCHAR(20)
);
GO

CREATE TABLE ProductionBatch (
    BatchID              INT           IDENTITY(1,1) PRIMARY KEY,
    BatchCode            VARCHAR(50),
    BatchDate            DATE,
    ProductionLineNumber INT,
    ShiftNumber          INT,
    RodModelID           INT,
    PlannedQty           INT,
    ActualQty            INT,
    GoodUnits            INT,
    DefectUnits          INT,
    CONSTRAINT FK_ProductionBatch_RodModel
        FOREIGN KEY (RodModelID) REFERENCES RodModel(RodModelID)
);
GO

CREATE TABLE DefectCode (
    DefectCode  VARCHAR(10)  PRIMARY KEY,
    Category    VARCHAR(5),
    Description VARCHAR(255)
);
GO

CREATE TABLE SeverityCode (
    SeverityCode VARCHAR(1)   PRIMARY KEY,
    Description  VARCHAR(100)
);
GO

CREATE TABLE QAInspection (
    InspectionID   INT  IDENTITY(1,1) PRIMARY KEY,
    BatchID        INT,
    InspectionDate DATE,
    CONSTRAINT FK_QAInspection_ProductionBatch
        FOREIGN KEY (BatchID) REFERENCES ProductionBatch(BatchID)
);
GO

CREATE TABLE QAInspectionDetail (
    InspectionDetailID INT  IDENTITY(1,1) PRIMARY KEY,
    InspectionID       INT,
    UnitNumber         INT,
    DefectCode         VARCHAR(10),
    SeverityCode       VARCHAR(1),
    Comments           VARCHAR(500),
    CONSTRAINT FK_QAInspectionDetail_QAInspection
        FOREIGN KEY (InspectionID) REFERENCES QAInspection(InspectionID),
    CONSTRAINT FK_QAInspectionDetail_DefectCode
        FOREIGN KEY (DefectCode)   REFERENCES DefectCode(DefectCode),
    CONSTRAINT FK_QAInspectionDetail_SeverityCode
        FOREIGN KEY (SeverityCode) REFERENCES SeverityCode(SeverityCode)
);
GO

CREATE TABLE FinishedGoodsInventory (
    InventoryID    INT  IDENTITY(1,1) PRIMARY KEY,
    BatchID        INT,
    RodModelID     INT,
    Quantity       INT,
    LocationStatus VARCHAR(20),
    CONSTRAINT FK_FinishedGoods_ProductionBatch
        FOREIGN KEY (BatchID)    REFERENCES ProductionBatch(BatchID),
    CONSTRAINT FK_FinishedGoods_RodModel
        FOREIGN KEY (RodModelID) REFERENCES RodModel(RodModelID)
);
GO

CREATE TABLE CustomerReturn (
    ReturnID       INT  IDENTITY(1,1) PRIMARY KEY,
    ReturnAuthCode VARCHAR(50),
    CustomerName   VARCHAR(100),
    RodModelID     INT,
    BatchCode      VARCHAR(50),
    ReturnReason   VARCHAR(500),
    DateReceived   DATE,
    Resolution     VARCHAR(20),
    CONSTRAINT FK_CustomerReturn_RodModel
        FOREIGN KEY (RodModelID) REFERENCES RodModel(RodModelID)
);
GO

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

--  Sample Data

-- RodModel (10 rows: mix of Good/Better/Primo, all four actions)
INSERT INTO RodModel (ModelCode, ActionCode, LengthFeet, Category) VALUES
('GR0506E', 'E', 5.50, 'Good'),
('GR0706M', 'M', 7.00, 'Good'),
('BR0906E', 'E', 9.50, 'Better'),
('BR0756F', 'F', 7.50, 'Better'),
('BR0906M', 'M', 9.50, 'Better'),
('BR0906S', 'S', 9.50, 'Better'),
('PR1006E', 'E', 10.50, 'Primo'),
('PR0906M', 'M', 9.00, 'Primo'),
('PR1006F', 'F', 10.50, 'Primo'),
('GR0606S', 'S', 6.00, 'Good');
GO

-- DefectCode
INSERT INTO DefectCode (DefectCode, Category, Description) VALUES
('B1', 'B', 'Wrong Length'),
('B2', 'B', 'Bad Paint'),
('B3', 'B', 'Scratched/Chipped Blank'),
('B4', 'B', 'Epoxy overage'),
('P1', 'P', 'Out of Spec for Action'),
('P2', 'P', 'Ferrules do not work correctly'),
('G1', 'G', 'Wrong guides for model'),
('G2', 'G', 'Chipped/Scratched'),
('G3', 'G', 'Epoxy over/underage'),
('G4', 'G', 'Bad wrap'),
('G5', 'G', 'One or more guides not aligned'),
('R1', 'R', 'Crooked'),
('R2', 'R', 'Does not operate correctly'),
('R3', 'R', 'Chipped/Scratched'),
('R4', 'R', 'Wrong Reel Set for model');
GO

-- SeverityCode
INSERT INTO SeverityCode (SeverityCode, Description) VALUES
('L', 'Minor defect, can be fixed during quality check'),
('M', 'Moderate defect, can be fixed in production'),
('H', 'Severe defect, unit must be scrapped'),
('S', 'Special, rod is good, put in Finished Goods for correct spec');
GO

-- ProductionBatch (10 rows)
INSERT INTO ProductionBatch (BatchCode, BatchDate, ProductionLineNumber, ShiftNumber, RodModelID, PlannedQty, ActualQty, GoodUnits, DefectUnits) VALUES
('190416-2.1', '2019-04-16', 1, 2, 3, 25, 25, 20, 5),
('190417-1.1', '2019-04-17', 1, 1, 5, 30, 28, 26, 2),
('190417-2.1', '2019-04-17', 2, 2, 4, 30, 30, 27, 3),
('190418-1.1', '2019-04-18', 1, 1, 7, 20, 20, 18, 2),
('190418-2.1', '2019-04-18', 2, 2, 1, 40, 38, 36, 2),
('190419-1.1', '2019-04-19', 1, 1, 6, 25, 24, 22, 2),
('190419-1.2', '2019-04-19', 1, 1, 3, 25, 25, 23, 2),
('190420-2.1', '2019-04-20', 2, 2, 8, 20, 19, 17, 2),
('190421-1.1', '2019-04-21', 1, 1, 9, 20, 20, 19, 1),
('190422-2.1', '2019-04-22', 2, 2, 2, 40, 40, 37, 3);
GO

-- QAInspection (one header per batch)
INSERT INTO QAInspection (BatchID, InspectionDate) VALUES
(1, '2019-04-17'),
(2, '2019-04-17'),
(3, '2019-04-18'),
(4, '2019-04-18'),
(5, '2019-04-19'),
(6, '2019-04-19'),
(7, '2019-04-20'),
(8, '2019-04-20'),
(9, '2019-04-22'),
(10, '2019-04-23');
GO

-- QAInspectionDetail (10 rows)
INSERT INTO QAInspectionDetail (InspectionID, UnitNumber, DefectCode, SeverityCode, Comments) VALUES
(1, 1,  'B3', 'L', 'Slight scratches near the bottom of the blank'),
(1, 2,  'B3', 'L', 'Minor scratch on blank mid-section'),
(1, 2,  'G5', 'M', '1st Guide out of alignment'),
(1, 3,  'B3', 'H', 'Gash across the middle, graphite cut through - scrapped'),
(1, 4,  'P1', 'S', 'Wrong spec, blank fits MH spec, saved for correct model'),
(1, 5,  'B2', 'M', 'Paint has blotches throughout, needs sanding and repainting'),
(1, 5,  'R3', 'L', 'Minor scratch on reel seat, buffed out during inspection'),
(2, 1,  'G4', 'M', 'Bad wrap on second guide from tip'),
(3, 2,  'B4', 'L', 'Epoxy overage near butt guide, cleaned during inspection'),
(4, 1,  'R2', 'H', 'Reel seat does not operate correctly, unit scrapped');
GO

-- FinishedGoodsInventory (10 rows)
INSERT INTO FinishedGoodsInventory (BatchID, RodModelID, Quantity, LocationStatus) VALUES
(1,  3,  20, 'Available'),
(2,  5,  26, 'Available'),
(3,  4,  27, 'Available'),
(4,  7,  18, 'Available'),
(5,  1,  36, 'Available'),
(6,  6,   2, 'Holding'),
(7,  3,  23, 'Available'),
(8,  8,  17, 'Available'),
(9,  9,  19, 'Available'),
(10, 2,  37, 'Available');
GO

-- CustomerReturn (10 rows)
INSERT INTO CustomerReturn (ReturnAuthCode, CustomerName, RodModelID, BatchCode, ReturnReason, DateReceived, Resolution) VALUES
('RA-001', 'James Carter', 3, '190416-2.1', 'Rod tip broke on first use',          '2019-05-10', 'Replacement'),
('RA-002', 'Linda Marsh',  7, '190418-1.1', 'Action feels wrong for listed spec',   '2019-05-12', 'Replacement'),
('RA-003', 'Tom Nguyen',   5, '190417-1.1', 'Paint chipping after one week',        '2019-05-15', 'Replacement'),
('RA-004', 'Sara Kim',     9, '190421-1.1', 'Reel seat loose, does not lock',       '2019-05-18', 'Repair'),
('RA-005', 'Bob Ellison',  3, '190419-1.2', 'Guide misaligned, line catches',       '2019-05-20', 'Replacement'),
('RA-006', 'Carol Diaz',   8, '190420-2.1', 'Scratch on blank visible at purchase', '2019-05-22', 'Refund'),
('RA-007', 'Mike Treanor', 4, '190417-2.1', 'Ferrule does not seat properly',       '2019-05-25', 'Replacement'),
('RA-008', 'Paula West',   7, '190418-1.1', 'Wrong length delivered',               '2019-05-28', 'Replacement'),
('RA-009', 'Greg Hollis',  2, '190422-2.1', 'Epoxy drip on blank near handle',      '2019-06-01', 'Repair'),
('RA-010', 'Diana Moore',  9, '190421-1.1', 'Rod snapped at ferrule joint',         '2019-06-03', 'Replacement');
GO

ALTER TABLE QAInspection
    DROP CONSTRAINT FK_QAInspection_ProductionBatch;

ALTER TABLE QAInspection
    ADD CONSTRAINT FK_QAInspection_ProductionBatch
    FOREIGN KEY (BatchID) REFERENCES ProductionBatch(BatchID)
    ON DELETE CASCADE;
GO

ALTER TABLE FinishedGoodsInventory
    DROP CONSTRAINT FK_FinishedGoods_ProductionBatch;

ALTER TABLE FinishedGoodsInventory
    ADD CONSTRAINT FK_FinishedGoods_ProductionBatch
    FOREIGN KEY (BatchID) REFERENCES ProductionBatch(BatchID)
    ON DELETE CASCADE;
GO

-- QAInspectionDetail cascades from QAInspection
ALTER TABLE QAInspectionDetail
    DROP CONSTRAINT FK_QAInspectionDetail_QAInspection;

ALTER TABLE QAInspectionDetail
    ADD CONSTRAINT FK_QAInspectionDetail_QAInspection
    FOREIGN KEY (InspectionID) REFERENCES QAInspection(InspectionID)
    ON DELETE CASCADE;
GO
