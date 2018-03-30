CREATE PROC uspCreateUserTable
AS
CREATE TABLE UserTable(
UserID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
FirstName VARCHAR(50),
LastName VARCHAR(50),
AddressLine1 VARCHAR(100),
AddressLine2 VARCHAR(100),
County VARCHAR(50),
EIRCode VARCHAR(7),
Email VARCHAR(100),
Phone VARCHAR(15),
Pass VARCHAR(50),
HashedPass VARCHAR(max),
UserType VARCHAR(100)
)
EXEC uspCreateUserTable
GO

DROP TABLE UserTable
GO

CREATE PROC uspInsertUser
@first VARCHAR(50),
@last VARCHAR(50),
@line1 VARCHAR(100),
@line2 VARCHAR(100),
@county VARCHAR(50),
@eir VARCHAR(7),
@email VARCHAR(100),
@phone VARCHAR(15),
@pass VARCHAR(max),
@type VARCHAR(100)
AS
INSERT INTO UserTable(FirstName, LastName, AddressLine1, AddressLine2, County, EIRCode, Email, Phone, Pass, UserType)
VALUES(@first ,@last, @line1, @line2, @county, @eir, @email, @phone, @pass, @type)
GO

CREATE PROC uspCreateStudioTable
AS
CREATE TABLE StudioTable(
StudioID VARCHAR(50) NOT NULL PRIMARY KEY,
StudioName VARCHAR(20),
StudioImage VARBINARY(MAX),
StudioStatus VARCHAR(30))
EXEC uspCreateStudioTable
GO

CREATE PROC uspCreateStudioType
AS
CREATE TABLE StudioTypeTable(
StudioTypeID VARCHAR(50) NOT NULL PRIMARY KEY,
StudioTypeDescription VARCHAR(200),
StudioStatus VARCHAR(20),
StudioPrice DECIMAL(5,2),
StudioID VARCHAR(50) FOREIGN KEY REFERENCES StudioTable(StudioID))
EXEC uspCreateStudioType
GO

CREATE PROC uspCreateReservationTable
AS
CREATE TABLE ReservationTable(
ReservationID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
StartDate datetime2,
EndDate datetime2,
UserID INT FOREIGN KEY REFERENCES UserTable(UserID),
StudioID VARCHAR(50) FOREIGN KEY REFERENCES StudioTable(StudioID))
EXEC uspCreateReservationTable
GO

CREATE PROC uspCreatePaymentTable
AS
CREATE TABLE PaymentTable(
PaymentID VARCHAR(100) NOT NULL PRIMARY KEY,
PaymentDate DATETIME2,
CardNumber VARCHAR(12),
ExpiryDate VARCHAR(5),
SecurityNumber VARCHAR(3),
UserID INT FOREIGN KEY REFERENCES UserTable(UserID),
ReservationID INT FOREIGN KEY REFERENCES ReservationTable(ReservationID))
EXEC uspCreatePaymentTable
GO

