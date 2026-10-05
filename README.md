# KodlamaNTierProject

Bu proje, Ubuntu ortamında .NET Core kullanılarak geliştirilmiş **N-Katmanlı (N-Tier Architecture)** mimariye sahip bir ASP.NET Core MVC web uygulamasıdır.

## Mimari Yapı
* **Entities:** Veritabanı varlıklarını (Models) barındırır.
* **DataAccess:** Entity Framework Core, SQLite, Generic Repository ve Unit of Work desenlerini içerir.
* **Business:** İş mantığı ve servis katmanıdır.
* **UI:** ASP.NET Core MVC arayüz katmanıdır.

## Kullanılan Teknolojiler
* .NET / C#
* ASP.NET Core MVC
* Entity Framework Core (EF Core)
* SQLite