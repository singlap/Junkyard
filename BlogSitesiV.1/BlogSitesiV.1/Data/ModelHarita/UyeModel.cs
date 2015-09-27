using BlogSitesiV._1.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BlogSitesiV._1.Data.ModelHarita
{
    public class UyeModel : EntityTypeConfiguration<Uye>
    {
        public UyeModel()
        {
            //Primary Key
            HasKey(t => t.uyeID);

            //Fields
            Property(t => t.uyeID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.uyeAd);
            Property(t => t.uyeSoyad);
            Property(t => t.uyeEmail);
            Property(t => t.uyeKullanici);
            Property(t => t.uyeSifre);

            ToTable("Uye");
        }

    }
}