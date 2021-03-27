using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
   public static  class Messages //sttaic yaptık çünkü new lememek için

    {
        public static string ProductAdded = "Ürün eklendi";
        public static string PrductNameInvalid = "ürün ismi geçersiz"; //ürün ismi geçersiz
        internal static string MaintenanceTime = "Sistem bakımda";
        internal static string ProductListed = "ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten bir isim var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        internal static string AuthorizationDenied = "Yetkiniz yok";
    }
}
