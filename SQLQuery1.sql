CREATE PROC uspCreateCustomerTable
AS
CREATE TABLE CustomerTable(
CustomerID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
FirstName VARCHAR(50),
LastName VARCHAR(50),
AddressLine1 VARCHAR(100),
AddressLine2 VARCHAR(100),
County VARCHAR(50),
EIRCode VARCHAR(7),
Email VARCHAR(100),
Phone VARCHAR(15),
Pass VARCHAR(50),
HashedPass VARCHAR(max)
)
EXEC uspCreateCustomerTable
GO

DROP TABLE CustomerTable

CREATE PROC uspInsertCustomer
@first VARCHAR(50),
@last VARCHAR(50),
@line1 VARCHAR(100),
@line2 VARCHAR(100),
@county VARCHAR(50),
@eir VARCHAR(7),
@email VARCHAR(100),
@phone VARCHAR(15),
@pass VARCHAR(max)
AS
INSERT INTO CustomerTable(FirstName, LastName, AddressLine1, AddressLine2, County, EIRCode, Email, Phone, Pass)
VALUES(@first ,@last, @line1, @line2, @county, @eir, @email, @phone, @pass)

CREATE PROC uspCreateStudioTable
AS
CREATE TABLE StudioTable(
StudioID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
StudioName VARCHAR(20),
StudioImage VARBINARY(MAX),
StudioStatus VARCHAR(30),
StudioType VARCHAR(20),
StudioTypeDescription VARCHAR(200),
StudioPrice DECIMAL(5,2))
EXEC uspCreateStudioTable
GO

CREATE PROC uspCreateReservationTable
AS
CREATE TABLE ReservationTable(
ReservationID int IDENTITY(10,1) NOT NULL PRIMARY KEY,
StartDate datetime2,
EndDate datetime2,
CustomerID INT FOREIGN KEY REFERENCES CustomerTable(CustomerID),
StudioID INT FOREIGN KEY REFERENCES StudioTable(StudioID))
EXEC uspCreateReservationTable
GO
