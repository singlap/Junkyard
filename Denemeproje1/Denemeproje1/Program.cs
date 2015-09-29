using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denemeproje1
{
    
    class Program : privateSinifiIcinDeneme1
    {
        
       
        static void Main(string[] args)
        {
            Console.WriteLine("merhaba dunya");
            Console.WriteLine("Bu oguzhanın branch ı");
            Console.WriteLine("Bu oguzhanın branch ı111");
            Console.WriteLine("Bu oguzhanın branch ı1111");
           
            Console.ReadKey();

            //OOP(object Oriented Programming), (Nesne Yönelimli Programlama), (NTP)

            //OOP 'de temel olarak bilinmesi gerenler;
            //- Classes (Sınıflar) ve Objects (Nesneler)
            //- Constructor (Yapıcı Metot) ve Destructor (Yıkıcı Metot)
            //- Overload (Aşırı yükleme)
            //- Encapsulation (Kapsülleme)
            //- Inheritance (Miras, Kalıtım)
            //- Interface (Arayüz)
            //- Polymorphizm (Çok Biçimlilik)

            /*Classes (Sınıflar) ve Objects (Nesneler)*/
           // Access Modifier i public olan sınıf klasından  nesne adında bir nesne oluşturulup  propertilerine değer atandı.
            sınıf nesne = new sınıf();

            nesne.aDegeri = 1;
            nesne.bDegeri = "asd";
            // kalıtım alınarak nesne oluşturulabildiği gibi  aynı namespace içerisinde tanımlanan bir metotdan kalıtım alınmadan da nesne oluşturulabiliyormuş.
            sınıf2 nesneOrnek = new sınıf2();
            nesneOrnek.digerBiryontem = 1;
            //sınıf2 metotdunun içerisinde tanımlanan digerBirYontem2 alanının access modifieri  private olduğu için o alana değer atayamıyoruz.
            //nesneOrnek.digerBiryontem2 = "2";

            // Access Modifier i private olan sınıf klasından  nesne2 adında bir nesne oluşturulup  propertilerine değer atandı.
            //Fakat diğer class içinde private olarak tanımlandığı için  program classı içinde erişim sağlanamayacağından hata verecektir.
            // Bu sebeple simdilik build edilebilmesi açısından yorum satırı haline getirildi.
            //privateSınıf nesne2 = new privateSınıf();
            //nesne2.aDegeri = 1;

            /*Erişim belirliyiciler (Access Modifiers)*/

            //-  Public : Bu erişim seviyesi belirtilmiş olan sınıflar, metotlar, alanlar sınırsız erişime sahiptir. Ve her yerden erişebiliriz.
            //- Private : Bu erişim seviyesinde sadece tanımlanan yerden erişebilir. Yani sınıf içinde tanımlandıysa sadece o sınıfta erişim sağlanır.
            //  Başka bir sınıfta kullanılamaz.
        }
       
    }
}
