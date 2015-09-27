using BlogSitesiV._1.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BlogSitesiV._1.Data.ModelHarita
{
    public class YoneticiModel : EntityTypeConfiguration<Yonetici>
    {
        public YoneticiModel()
        {
            //Primary Key
            HasKey(t => t.yoneticiID);

            //Fields
            Property(t => t.yoneticiAd);
            Property(t => t.yoneticiSoyad);
            Property(t => t.yoneticiKullanici);
            Property(t => t.yoneticiSifre);
        }
    }
}