# Employee Management API

Project REST API ASP.NET Core menggunakan pendekatan Code-First.

## Fitur
- Tambah, ubah, hapus, cari data karyawan
- REST API dengan endpoint standar

## Cara Menjalankan

1. Buka terminal dan restore dependensi:
   ```
   dotnet restore
   ```

2. Buat database dengan migrasi EF Core:
   ```
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

3. Jalankan aplikasi:
   ```
   dotnet run
   ```

4. Akses Swagger di:
   ```
   http://localhost:<port>/swagger
   ```

## Tools
- ASP.NET Core 8.0
- Entity Framework Core (Code First)
- SQL Server (LocalDb)

## Endpoint
- GET `/api/employees`
- GET `/api/employees/{id}`
- POST `/api/employees`
- PUT `/api/employees/{id}`
- DELETE `/api/employees/{id}`
- GET `/api/employees/search?name=xxx&position=yyy`
