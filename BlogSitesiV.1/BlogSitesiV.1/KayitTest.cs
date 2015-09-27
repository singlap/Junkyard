using BlogSitesiV._1.Data;
using BlogSitesiV._1.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogSitesiV._1
{
    [TestClass] 
    public class KayitTest
    {
        [TestMethod]
        public void UyeKayitTest()
        {
            Database.SetInitializer<Context>(new CreateDatabaseIfNotExists<Context>());
            using (var context = new Context())
            {
                //context.Database.Create();
                Uye uye = new Uye
                {
                    uyeID = 1,
                    uyeEmail="abrukcebir@gmail.com",
                    uyeAd="arbuk",
                    uyeSoyad="cebir",
                    uyeKullanici="arbkcbr",
                    uyeSifre="arbkcbr123",
                    



                    Yorums = new List<Yorum>{  
                                            new Yorum  
                                            {  
                                                yorumID=1,
                                                YorumOnay=false,
                                                yorumResim="www.resim.com/asd/asds.png",
                                                yorumTarih=DateTime.Now
                                            },  
                                            new Yorum  
                                            {
                                                yorumID=2,
                                                YorumOnay =true,  
                                                yorumResim="www.resim.com/asd/asdffs.png",  
                                                yorumTarih=DateTime.Now
                                                  
                                            }  
                                        },
                   

                };
                Kategori kategori = new Kategori
                {
                    kategoriID = 1,
                    kategoriAd = "Asp.Net",
                    kategoriResim = "www.resim.com/asd/asssscsdffs.png",

                    Makales = new List<Makale>{
                                             new Makale
                                                {
                                                makaleID=1,
                                                kategoriID=1,
                                                makaleBaslik="asda",
                                                makaleIcerik="asdasdasd",
                                                makaleOkunma=0,
                                                makaleOzet="fasfagghhhhh",
                                                makaleResim="www.resim.com/asd/asdffs.png",
                                                makaleYorumSayisi=0,
                                                 

                                               
                                                },
                                             new Makale
                                                {
                                                makaleID=2,
                                                kategoriID=1,
                                                makaleBaslik="asda",
                                                makaleIcerik="asdasdasd",
                                                makaleOkunma=0,
                                                makaleOzet="fasfagghhhhh",
                                                makaleResim="www.resim.com/asd/asdffs.png",
                                                makaleYorumSayisi=0
                                                 }
                                            }
                };
                    


                 //context.Entry(uye).State = System.Data.EntityState.added;
                context.Uyes.Add(uye);
                context.Kategoris.Add(kategori);



                context.SaveChanges();
            }
        }
    }
}