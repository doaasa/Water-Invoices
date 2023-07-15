
CREATE DATABASE Water_Invoices;
use Water_Invoices;


CREATE TABLE NWC_Rreal_Estate_Types (
    NWC_Rreal_Estate_Types_Code Char(1) primary key,
    NWC_Rreal_Estate_Types_Name varchar(15),
    NWC_Rreal_Estate_Types_Reasons varchar(100)
);

CREATE TABLE NWC_Subscriber_File (
NWC_Subscriber_File_Id char(10) primary key,
NWC_Subscriber_File_Name varchar(100),
NWC_Subscriber_File_City varchar(50),
NWC_Subscriber_File_Area varchar(50),
NWC_Subscriber_File_Mobile varchar(20),
NWC_Subscriber_File_Reasons varchar(100)

);

CREATE TABLE NWC_Default_Slice_Values(
NWC_Default_Slice_Values_Code char(1) primary key,
NWC_Default_Slice_Values_Name varchar(50),
NWC_Default_Slice_Values_Condtion int,
CONSTRAINT NWC_Default_Slice_Values_Condtion CHECK (NWC_Default_Slice_Values_Condtion >= 0 AND NWC_Default_Slice_Values_Condtion <= 999),
NWC_Default_Slice_Values_Water_Price decimal (6,2),
NWC_Default_Slice_Values_Sanitation_Price decimal (6,2),
NWC_Default_Slice_Values_Reasons varchar(100)
);

CREATE TABLE NWC_Subscription_File (
NWC_Subscription_File_No char(10) primary key,
NWC_Subscription_File_Subscriber_Code char(10) ,
NWC_Subscription_File_Rreal_Estate_Types_Code char(1),
NWC_Subscription_File_Unit_No int,
CONSTRAINT NWC_Subscription_File_Unit_No CHECK (NWC_Subscription_File_Unit_No >= 0 AND NWC_Subscription_File_Unit_No <= 99),
NWC_Subscription_File_Is_There_Sanitation bit,
NWC_Subscription_File_Last_Reading_Meter numeric(10,0),
NWC_Subscription_File_Reasons varchar(100),
FOREIGN KEY (NWC_Subscription_File_Subscriber_Code) REFERENCES NWC_Subscriber_File(NWC_Subscriber_File_Id)   ON DELETE CASCADE ON UPDATE CASCADE


,FOREIGN KEY (NWC_Subscription_File_Rreal_Estate_Types_Code) REFERENCES NWC_Rreal_Estate_Types(NWC_Rreal_Estate_Types_Code)ON DELETE CASCADE ON UPDATE CASCADE


);


CREATE TABLE NWC_Invoices	(
NWC_Invoices_No char(10) primary key,
NWC_Invoices_Year char(2),
NWC_Invoices_Rreal_Estate_Types char(1),

NWC_Invoices_Subscription_No char(10),

NWC_Invoices_Subscriber_No char(10),

NWC_Invoices_Date date,
NWC_Invoices_From date,
NWC_Invoices_To date,
NWC_Invoices_Previous_Consumption_Amount numeric (10,0),
NWC_Invoices_Current_Consumption_Amount numeric(10,0),
NWC_Invoices_Amount_Consumption numeric(10,0),
NWC_Invoices_Service_Fee decimal (10,2),
NWC_Invoices_Tax_Rate decimal (10,2),
NWC_Invoices_Is_There_Sanitation bit,
NWC_Invoices_Consumption_Value decimal (10,2),
NWC_Invoices_Wastewater_Consumption_Value decimal (10,2),
NWC_Invoices_Total_Invoice decimal (10,2),
NWC_Invoices_Tax_Value decimal (10,2),
NWC_Invoices_Total_Bill decimal (10,2),
NWC_Invoices_Total_Reasons varchar(100),


FOREIGN KEY (NWC_Invoices_Subscriber_No) REFERENCES NWC_Subscriber_File(NWC_Subscriber_File_Id)  ,

FOREIGN KEY (NWC_Invoices_Subscription_No) REFERENCES NWC_Subscription_File(NWC_Subscription_File_No)ON DELETE CASCADE  ON UPDATE CASCADE,

FOREIGN KEY (NWC_Invoices_Rreal_Estate_Types) REFERENCES NWC_Rreal_Estate_Types(NWC_Rreal_Estate_Types_Code) 

);





INSERT INTO NWC_Default_Slice_Values (NWC_Default_Slice_Values_Code, NWC_Default_Slice_Values_Name, NWC_Default_Slice_Values_Condtion,NWC_Default_Slice_Values_Water_Price,NWC_Default_Slice_Values_Sanitation_Price,NWC_Default_Slice_Values_Reasons)
SELECT NWC_Default_Slice_Values_Code, NWC_Default_Slice_Values_Name, NWC_Default_Slice_Values_Condtion,NWC_Default_Slice_Values_Water_Price,NWC_Default_Slice_Values_Sanitation_Price,NWC_Default_Slice_Values_Reasons
FROM Default_Slice_Values$
Where NWC_Default_Slice_Values_Code IS NOT NULL;


INSERT INTO NWC_Subscription_File (NWC_Subscription_File_No, NWC_Subscription_File_Subscriber_Code, NWC_Subscription_File_Rreal_Estate_Types_Code,NWC_Subscription_File_Unit_No,NWC_Subscription_File_Is_There_Sanitation,NWC_Subscription_File_Last_Reading_Meter,NWC_Subscription_File_Reasons)
SELECT NWC_Subscription_File_No , CAST(NWC_Subscription_File_Subscriber_Code AS INT), NWC_Subscription_File_Rreal_Estate_Types_Code,NWC_Subscription_File_Unit_No,NWC_Subscription_File_Is_There_Sanitation,NWC_Subscription_File_Last_Reading_Meter,NWC_Subscription_File_Reasons
FROM Subscription_File_Data$
Where NWC_Subscription_File_No IS NOT NULL;



INSERT INTO NWC_Subscriber_File (NWC_Subscriber_File_Id, NWC_Subscriber_File_Name, NWC_Subscriber_File_City,NWC_Subscriber_File_Area,NWC_Subscriber_File_Mobile)
SELECT NWC_Subscriber_File_Id, NWC_Subscriber_File_Name, NWC_Subscriber_File_City,NWC_Subscriber_File_Area,NWC_Subscriber_File_Mobile
FROM Subscriber_File_Data$
Where NWC_Subscriber_File_Id IS NOT NULL;
