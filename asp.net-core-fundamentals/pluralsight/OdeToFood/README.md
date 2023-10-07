#README


```
docker run --cap-add SYS_PTRACE -e 'ACCEPT_EULA=1' -e 'MSSQL_SA_PASSWORD=Password1' -p 1433:1433 --name azuresqledge -d mcr.microsoft.com/azure-sql-edge

The coonnection strings
"OdeToFoodDb": "Data Source=localhost;Initial Catalog=OdeToFood;User Id=SA;Password=Password1;Encrypt=False;TrustServerCertificate=True;"

```

## How to run migrations info

```
felixperez@Felixs-MacBook-Pro OdeToFood.Data % dotnet ef dbcontext info -s ../OdeToFood/OdeToFood.csproj
Build started...
Build succeeded.
Type: OdeToFood.Data.OdeToFoodDbContext
Provider name: Microsoft.EntityFrameworkCore.SqlServer
Database name: OdeToFood
Data source: localhost
Options: MaxPoolSize=1024
```

## Initial Migraton

```
felixperez@Felixs-MacBook-Pro OdeToFood.Data % dotnet ef migrations add initialcreate -s ../OdeToFood/OdeToFood.csproj
Build started...
Build succeeded.
```

## Update-Migration

```
felixperez@Felixs-MacBook-Pro OdeToFood.Data % dotnet ef database update -s ../OdeToFood/OdeToFood.csproj
Build started...
Build succeeded.
```