# NorthwindDataService

This C# project demonstrates a simple approach to creating a 'Data Service' that can be packaged into a dll from a class library.  Using the world's most referenced fictional database, Northwind Traders (for which the SQL to re-create this is available here on Github), this uses factories to reference stored procedures in the database.  Although not done here, this class library could be packaged into NuGet for use within an commerical organisation so that developers can reference the data through this rather than through direct access to the database.
