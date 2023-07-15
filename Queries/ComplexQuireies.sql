SELECT t1.NWC_Subscription_File_No, t1.NWC_Subscription_File_Subscriber_Code, t2.NWC_Subscriber_File_Name,t2.NWC_Subscriber_File_Mobile,t3.NWC_Rreal_Estate_Types_Name,t1.NWC_Subscription_File_Unit_No,CASE WHEN t1.NWC_Subscription_File_Is_There_Sanitation = 1 THEN '‰⁄„' ELSE '·«' END AS 'NWC_Subscription_File_Is_There_Sanitation',t1.NWC_Subscription_File_Last_Reading_Meter,t1.NWC_Subscription_File_Reasons

FROM NWC_Subscription_File t1
LEFT JOIN NWC_Subscriber_File t2 ON t1.NWC_Subscription_File_Subscriber_Code = t2.NWC_Subscriber_File_Id
LEFT JOIN NWC_Rreal_Estate_Types t3 ON t1.NWC_Subscription_File_Rreal_Estate_Types_Code = t3.NWC_Rreal_Estate_Types_Code


Select t1.NWC_Subscriber_File_Id,t1.NWC_Subscriber_File_Name,t1.NWC_Subscriber_File_City,t1.NWC_Subscriber_File_Area,t1.NWC_Subscriber_File_Mobile , COUNT(t2.NWC_Subscription_File_Subscriber_Code) AS count
from NWC_Subscriber_File t1 
LEFT JOIN NWC_Subscription_File t2 ON t1.NWC_Subscriber_File_Id = t2.NWC_Subscription_File_Subscriber_Code
GROUP BY t1.NWC_Subscriber_File_Id,t1.NWC_Subscriber_File_Name,t1.NWC_Subscriber_File_City,t1.NWC_Subscriber_File_Area,t1.NWC_Subscriber_File_Mobile


SELECT t1.NWC_Invoices_No,t1.NWC_Invoices_Subscription_No, t1.NWC_Invoices_Subscriber_No,
t2.NWC_Subscriber_File_Name,CONVERT(varchar, t1.NWC_Invoices_Date, 3) AS formatted_date,t1.NWC_Invoices_Previous_Consumption_Amount,t1.NWC_Invoices_Current_Consumption_Amount,
t1.NWC_Invoices_Amount_Consumption,t1.NWC_Invoices_Total_Invoice,t1.NWC_Invoices_Total_Bill
FROM NWC_Invoices t1
LEFT JOIN NWC_Subscriber_File t2 ON t1.NWC_Invoices_Subscriber_No=t2.NWC_Subscriber_File_Id


SELECT t1.NWC_Invoices_Date,t1.NWC_Invoices_From,t1.NWC_Invoices_To,t1.NWC_Invoices_Subscription_No,
t1.NWC_Invoices_Subscriber_No , t2.NWC_Subscriber_File_Name,
t1.NWC_Invoices_Previous_Consumption_Amount,t1.NWC_Invoices_Current_Consumption_Amount,
t1.NWC_Invoices_Amount_Consumption,
CASE WHEN t1.NWC_Invoices_Is_There_Sanitation = 1 THEN '‰⁄„' ELSE '·«' END AS 'NWC_Subscription_File_Is_There_Sanitation'
,t3.NWC_Subscription_File_Unit_No,t1.NWC_Invoices_Service_Fee,
t1.NWC_Invoices_Tax_Rate,t1.NWC_Invoices_Consumption_Value,
t1.NWC_Invoices_Wastewater_Consumption_Value,t1.NWC_Invoices_Total_Invoice,
t1.NWC_Invoices_Total_Bill
FROM NWC_Invoices t1
LEFT JOIN NWC_Subscriber_File t2 ON t1.NWC_Invoices_Subscriber_No=t2.NWC_Subscriber_File_Id
LEFT JOIN NWC_Subscription_File t3 ON t1.NWC_Invoices_Subscription_No = t3.NWC_Subscription_File_No

WHERE t1.NWC_Invoices_No='2023-2-321'


select * from NWC_Invoices
