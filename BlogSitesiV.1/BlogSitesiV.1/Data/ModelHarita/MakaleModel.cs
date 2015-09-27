using BlogSitesiV._1.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BlogSitesiV._1.Data.ModelHarita
{
    public class MakaleModel : EntityTypeConfiguration<Makale>
    {
        public MakaleModel()
        {
            //Primary Key
            HasKey(t => t.makaleID);
            //Fields
            Property(t => t.makaleBaslik);
            Property(t => t.makaleOzet);
            Property(t => t.makaleIcerik);
            Property(t => t.makaleResim);
            Property(t => t.makaleOkunma);
            Property(t => t.makaleYorumSayisi);
            ToTable("Makale");

            //Relationship
            HasRequired(t => t.kategori).WithMany(z => z.Makales).HasForeignKey(t => t.kategoriID).WillCascadeOnDelete(false);
        }
    }
}