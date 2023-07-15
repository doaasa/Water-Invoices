select * from NWC_Invoices	;

select * from NWC_Rreal_Estate_Types;


update NWC_Rreal_Estate_Types set NWC_Rreal_Estate_Types_Name ='" + details + "' where NWC_Rreal_Estate_Types_Code ='"+num+"'

select  NWC_Rreal_Estate_Types_Name from NWC_Rreal_Estate_Types where NWC_Rreal_Estate_Types_Code =1


select * from NWC_Subscriber_File;
select * from NWC_Invoices	;

select * from NWC_Subscription_File	;

select NWC_Subscriber_File_Name from NWC_Subscriber_File where NWC_Subscriber_File_Id='"++"'

insert into NWC_Subscription_File(NWC_Subscription_File_No,NWC_Subscription_File_Subscriber_Code,NWC_Subscription_File_Rreal_Estate_Types_Code,NWC_Subscription_File_Unit_No,NWC_Subscription_File_Is_There_Sanitation,NWC_Subscription_File_Last_Reading_Meter,NWC_Subscription_File_Reasons)values(@NWC_Subscription_File_No,@NWC_Subscription_File_Subscriber_Code,@NWC_Subscription_File_Rreal_Estate_Types_Code,@NWC_Subscription_File_Unit_No,@NWC_Subscription_File_Is_There_Sanitation,@NWC_Subscription_File_Last_Reading_Meter,@NWC_Subscription_File_Reasons)

select * from NWC_Invoices		;

insert into NWC_Invoices(NWC_Invoices_No,NWC_Invoices_Year,NWC_Invoices_Rreal_Estate_Types,NWC_Invoices_Subscription_No,NWC_Invoices_Subscriber_No,NWC_Invoices_Date,NWC_Invoices_From,NWC_Invoices_To,NWC_Invoices_Previous_Consumption_Amount
,NWC_Invoices_Current_Consumption_Amount
,NWC_Invoices_Amount_Consumption
,NWC_Invoices_Service_Fee
,NWC_Invoices_Tax_Rate
,NWC_Invoices_Is_There_Sanitation
,NWC_Invoices_Consumption_Value
,NWC_Invoices_Wastewater_Consumption_Value
,NWC_Invoices_Total_Invoice
,NWC_Invoices_Tax_Value
,NWC_Invoices_Total_Bill
,NWC_Invoices_Total_Reasons ) values (
@NWC_Invoices_No,
@NWC_Invoices_Year,
@NWC_Invoices_Rreal_Estate_Types,
@NWC_Invoices_Subscription_No,
@NWC_Invoices_Subscriber_No,
@NWC_Invoices_Date,
@NWC_Invoices_From,
@NWC_Invoices_To,
@NWC_Invoices_Previous_Consumption_Amount
,@NWC_Invoices_Current_Consumption_Amount
,@NWC_Invoices_Amount_Consumption
,@NWC_Invoices_Service_Fee
,@NWC_Invoices_Tax_Rate
,@NWC_Invoices_Is_There_Sanitation
,@NWC_Invoices_Consumption_Value
,@NWC_Invoices_Wastewater_Consumption_Value
,@NWC_Invoices_Total_Invoice
,@NWC_Invoices_Tax_Value
,@NWC_Invoices_Total_Bill
,@NWC_Invoices_Total_Reasons ) 


use Water_Invoices
select count(*) as '⁄œœ «·„—« ' from NWC_Subscription_File where NWC_Subscription_File_Subscriber_Code = '1008533912'

CREATE PROC Sp_User
AS
BEGIN
SELECT m.NWC_Subscriber_File_Id AS '—ﬁ„ «·ÂÊÌ…',
m.NWC_Subscriber_File_Name AS '«·«”„',
m.NWC_Subscriber_File_City AS '«·„œÌ‰…',
m.NWC_Subscriber_File_Area AS '«·ÕÌ',
m.NWC_Subscriber_File_Mobile AS '—ﬁ„ «·ÃÊ«·'
FROM NWC_Subscriber_File as m
END

