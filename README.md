# Web API with EF 7 - Relationships Practice
DONE: June 10, 2023 `14:07:47` (14 hours yes)
- ### Designing and Creating an API with multiple databases (SQL Server)
- ### Practicing Relationships: 1:1, 1:n, n:n

## Learned:
- DTOs
- Creating DTOs involving multiple databases
- `[JsonIgnore]` for preventing property from serializing and deserializing 
- Importance of Patterns (Repository Pattern, etc.)
- DI for `DataContext` in `Program.cs`
- Returning multiple variables (data) from multiple databases based on given Id (see `GetCharacterById`)
  - the `Includes` method and the `FirstOrDefaultAsync` method
- JUNCTION table in database (see SQL Server) --> for managing `n:n` relationships (see Weapons and Factions table)

**NuGet Packages:**
- Download EF Core, EF.SqlServer, EF.Design

**`DbContext`:**
- after adding `DbSet` → run:
```bash
dotnet ef migrations add <Message>
```
- EF creates Migrations directory for the history of DB migrations
- then create the database itself if not exists: 
```bash
dotnet ef database update
```
### If adding a new DbSet or database:
- create new class in **Models** directory
- add the new DB model class as `DbSet` in `DataContext` class
- run:
```bash
- dotnet ef migrations add <Message>
```
- notice the update in the **Migrations** directory
- then run: 
```bash
- dotnet ef database update
``` 
- to update the database in SQL Server (or any provider) 

## Technologies:
- C#
- .NET
- ASP.NET Web API
- Entity Framework 7
- SQL Server