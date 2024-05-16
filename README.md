## Migration

### Create a new migration

```
dotnet ef migrations add InitialCreate --project Data --startup-project Presentation --output-dir Migrations --context ApplicationDbContext
```

### Update the database

```
dotnet ef database update --project Data --startup-project Presentation --context ApplicationDbContext
```

### Remove the last migration

```
dotnet ef migrations remove --project Data --startup-project Presentation
```

## Run the application

```
dotnet run --project Presentation
```