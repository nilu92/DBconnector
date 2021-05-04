# DBconnector

<add name="Sample" connectionString="Server=(localdb)\MSSQLLocalDB;Database=Sample; User=DESKTOP-E57017B\Nikla; Trusted_Connection=True;" providerName="System.Data.SqlClient" />
///Stored Procedure
create proc sp_productInsert
@ProductID int,
@ItemName nvarchar(50),
@Color nvarchar(50),
@ExpiryDate datetime
as
begin
Insert into Productinfo_Tab(ProductID,ItemName,Color,ExpiryDate)
values(@ProductID,@ItemName,@Color,@ExpiryDate)
end

//Helper
// Refer to Connection string in appsetting 
public static string CnVal(string name)
        {
          return  ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
