using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denemeproje1 
{
    class privateSinifiIcinDeneme1 
    {
        // sınıf yaratıldı
        public class sınıf
        {
            //Fields(Alanlar) ve (Properties)Özellikleri belirtildi
            public int aDegeri { get; set; }
            public string bDegeri { get; set; }

        }
        // sınıf yaratıldı
        private class privateSınıf
        {
            //Fields(Alanlar) ve (Properties)Özellikleri belirtildi
            public int aDegeri { get; set; }
            public string bDegeri { get; set; }

        }

    }
    // "aynı namespace içerisinde tanımlanan sınıflardan kalıtım almadan  nesne oluşturulabiliyormu? " örneği
     class sınıf2
    {
        public int digerBiryontem { get; set; }
        private string digerBirYontem2 { get; set; }
    }
}
