

## Key-Value Store API
Bu proje, .NET 8 kullanarak basit bir key-value store (anahtar-değer depolama) API'si sağlar. API, JSON verilerini PostgreSQL veritabanında saklamak için Marten kütüphanesini kullanır ve verileri Docker konteynerlerinde çalıştırır.

## Proje İçeriği
- .NET 8 SDK ile geliştirilmiş minimal bir API.
- Veritabanı olarak PostgreSQL kullanılıyor.
- Marten kütüphanesi ile PostgreSQL'e veri ekleniyor, güncelleniyor ve siliniyor.
- API, konteyner tabanlı bir yapıda Docker Compose ile yönetiliyor.
# Özellikler
- GET /api/keyvalue/{id}: Verilen id ile kaydı getirir.
- POST /api/keyvalue: Yeni bir kayıt oluşturur veya var olan kaydı günceller.
- DELETE /api/keyvalue/{id}: Verilen id ile kaydı siler.
