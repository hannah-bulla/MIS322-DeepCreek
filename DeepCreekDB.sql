CREATE DATABASE IF NOT EXISTS DeepCreekDB;
USE DeepCreekDB;

CREATE TABLE RodModel (
    RodModelID   INT AUTO_INCREMENT PRIMARY KEY,
    ModelCode    VARCHAR(50),
    ActionCode   VARCHAR(1),
    LengthFeet   DECIMAL(5,2),
    Category     VARCHAR(20)
);

CREATE TABLE ProductionBatch (
    BatchID              INT AUTO_INCREMENT PRIMARY KEY,
    BatchCode            VARCHAR(50),
    BatchDate            DATE,
    ProductionLineNumber INT,
    ShiftNumber          INT,
    RodModelID           INT,
    PlannedQty           INT,
    ActualQty            INT,
    GoodUnits            INT,
    DefectUnits          INT,
    FOREIGN KEY (RodModelID) REFERENCES RodModel(RodModelID)
);

CREATE TABLE DefectCode (
    DefectCode  VARCHAR(10) PRIMARY KEY,
    Category    VARCHAR(5),
    Description VARCHAR(255)
);

CREATE TABLE SeverityCode (
    SeverityCode VARCHAR(1) PRIMARY KEY,
    Description  VARCHAR(100)
);

CREATE TABLE QAInspection (
    InspectionID   INT AUTO_INCREMENT PRIMARY KEY,
    BatchID        INT,
    InspectionDate DATE,
    FOREIGN KEY (BatchID) REFERENCES ProductionBatch(BatchID)
);

CREATE TABLE QAInspectionDetail (
    InspectionDetailID INT AUTO_INCREMENT PRIMARY KEY,
    InspectionID       INT,
    UnitNumber         INT,
    DefectCode         VARCHAR(10),
    SeverityCode       VARCHAR(1),
    Comments           VARCHAR(500),
    FOREIGN KEY (InspectionID) REFERENCES QAInspection(InspectionID),
    FOREIGN KEY (DefectCode)   REFERENCES DefectCode(DefectCode),
    FOREIGN KEY (SeverityCode) REFERENCES SeverityCode(SeverityCode)
);

CREATE TABLE FinishedGoodsInventory (
    InventoryID    INT AUTO_INCREMENT PRIMARY KEY,
    BatchID        INT,
    RodModelID     INT,
    Quantity       INT,
    LocationStatus VARCHAR(20),
    FOREIGN KEY (BatchID)    REFERENCES ProductionBatch(BatchID),
    FOREIGN KEY (RodModelID) REFERENCES RodModel(RodModelID)
);

CREATE TABLE CustomerReturn (
    ReturnID       INT AUTO_INCREMENT PRIMARY KEY,
    ReturnAuthCode VARCHAR(50),
    CustomerName   VARCHAR(100),
    RodModelID     INT,
    BatchCode      VARCHAR(50),
    ReturnReason   VARCHAR(500),
    DateReceived   DATE,
    Resolution     VARCHAR(20),
    FOREIGN KEY (RodModelID) REFERENCES RodModel(RodModelID)
);
