using BlogSitesiV._1.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BlogSitesiV._1.Data.ModelHarita
{
    public class KategoriModel : EntityTypeConfiguration<Kategori>
    {
        public KategoriModel()
        {
            //Primary Key
            HasKey(t => t.kategoriID);

            //Fields
            Property(t => t.kategoriAd);
            Property(t => t.kategoriAdet);
            Property(t => t.kategoriResim);

            ToTable("Kategori");

        }
    }
}