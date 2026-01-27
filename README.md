# DentalConnect: Klinik Kayıt ve Giriş Sistemi 🦷💻

Bu proje, diş klinikleri için özel olarak tasarlanmış, güvenli ve kullanıcı dostu bir yetkilendirme (Authentication) modülüdür. Kullanıcıların (hasta veya personel) sisteme güvenli bir şekilde kayıt olmasını ve giriş yapmasını sağlar.

## ✨ Öne Çıkan Özellikler
- **Kullanıcı Kayıt (Sign-Up):** Yeni kullanıcılar için veri doğrulama kontrollü kayıt formu.
- **Güvenli Giriş (Sign-In):** MSSQL tabanlı kimlik doğrulama mekanizması.
- **Dinamik Veri Yönetimi:** Kullanıcı verilerinin MSSQL Server üzerinde ilişkisel tablo yapısında saklanması.
- **Modern Arayüz:** HTML5 ve CSS3 ile hazırlanmış, diş kliniği konseptine uygun temiz ve profesyonel tasarım.

## 🛠️ Teknik Altyapı
- **Backend:** ASP.NET Core MVC
- **Veritabanı:** Microsoft SQL Server (MSSQL)
- **Frontend:** HTML5, CSS3, JavaScript
- **Veri Erişimi:** Entity Framework Core (veya kullandığın diğer yöntem)

## 📂 Veritabanı Şeması
Proje, MSSQL üzerinde aşağıdaki temel kullanıcı verilerini yönetmektedir:
- Kullanıcı Adı / E-posta
- Şifre (Hashlenmiş)
- Kayıt Tarihi
- Kullanıcı Rolü (Örn: Hasta, Doktor)


## 🚀 Kurulum ve Çalıştırma

1. **Veritabanını Hazırlayın:**
   - MSSQL Server'da yeni bir veritabanı oluşturun.
   - `appsettings.json` dosyasındaki Connection String bilgisini kendi yerel sunucunuza göre güncelleyin.

2. **Projeyi Çalıştırın:**
   ```bash
   dotnet build
   dotnet run
