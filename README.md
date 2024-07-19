# EntityFramwork

## Getting started

- Visual Studio 2022
- .Net 8
- [AP database](create_ap.sql) installed
- AP database connection string in appsettings.json

You may need to chasnge the DB connection string located in teh APContext class.
By default, it points to mssqllocaldb. You can change it to your own database.
```csharp
optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AP");
```


Right click on the project -> Manage Nuget Packages -> Browse
Then install these packages below
```bash
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.Design
```

Click on Tools -> nuget package manager -> package manager console
Type the command below to generate the models
```csharp
Scaffold-DbContext 'Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AP' Microsoft.EntityFrameworkCore.SqlServer
```