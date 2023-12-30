using CorePackages.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants;

public static class Messages
{
    public static string ProductAdded = "Urun eklendi";
    public static string ProductNameInvalid = "Urun ismi gecersiz";
    public static string MaintenanceTime = "Sistem bakimda";
    public static string ProductListed = "Urunler listelendi";
    public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 urun olabilir.";
    public static string ProductNameAlreadyExits = "Bu isimde zaten baska bir urun var.";
    public static string CategoryLimitExceded = "Kategori limiti asildigi icin yeni urun eklenemiyor.";


    public static string AuthorizationDenied = "Yetkiniz yok";
    public static string UserRegistered = "Kayit olundu";
    public static string UserNotFound = "Kullanici bulunamadi";
    public static string PasswordError = "Sifre hatali";
    public static string SuccessfulLogin = "Sisteme basariyla giris yapildi";
    public static string UserAlreadyExists = "Bu kullanici zaten mevcut";
    public static string AccessTokenCreated = "Access token basariyla olusturuldu";
}
