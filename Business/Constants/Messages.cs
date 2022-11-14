using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProductCountOFCategoryError = "Bu katagoride 10dan fazla ürün eklenemez!";
        public static string ProductNameAlreadyExists = "Aynı isim de iki ürün eklenemez!";
        public static string CategoryLimitExceded = "Kategori limiti 15'dir!";
    }
}
