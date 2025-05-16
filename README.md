# 🧩 FinalProject – Katmanlı Mimaride C# Web API

Bu proje, C# ve ASP.NET Core ile geliştirilmiş, Entity Framework Core kullanan çok katmanlı bir Web API uygulamasıdır. Amaç; `Product` (ürün) nesneleri üzerinden RESTful servisler sunmak ve temiz, test edilebilir bir mimari örneği göstermektir.

---

## 📦 Proje Mimarisi

Proje aşağıdaki katmanlardan oluşur:

- **Entities**: Veri modelleri (`Product` gibi)
- **DataAccess**: Veritabanı işlemleri (EF Core kullanılarak)
- **Business**: İş kuralları ve servis arayüzleri
- **Core**: Ortak altyapı kodları (IResult, Utilities, vb.)
- **WebAPI**: Uygulamanın HTTP servislerini sunan API katmanı
- **ConsoleUI**: (Varsa) Konsol üzerinden uygulama testi

---

## 🔧 Temel Özellikler

- ✅ `ProductsController` ile ürün listeleme (`GET api/products/getall`)
- ✅ Katmanlı mimari ile modüler yapı
- ✅ Dependency Injection ile `IProductService` bağlanımı
- ✅ Entity Framework Core ile veri erişimi
- ✅ Swagger entegrasyonu kolayca yapılabilir

---

## 🚀 Nasıl Çalıştırılır?

### 1. Gerekli Araçlar
- [.NET SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2022 veya VS Code

### 2. Projeyi Aç

`FinalProject.sln` dosyasını Visual Studio ile açın.

### 3. `WebAPI` projesini başlatın

Varsayılan olarak `WeatherForecastController` ve `ProductsController` aktif olacaktır.

---

## 📁 Örnek API Endpoint

```http
GET /api/products/getall
```

Dönen cevap:

```json
{
  "success": true,
  "message": "Ürünler listelendi",
  "data": [
    {
      "id": 1,
      "name": "Laptop",
      "price": 12000
    }
  ]
}
```

---

## 🧠 Kullanılan Teknolojiler

- C# (.NET 6 veya üzeri)
- ASP.NET Core Web API
- Entity Framework Core
- Katmanlı Mimari (SOLID prensipleri)
- RESTful API yapısı

---

