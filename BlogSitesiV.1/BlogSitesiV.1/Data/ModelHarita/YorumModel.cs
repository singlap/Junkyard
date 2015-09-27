using BlogSitesiV._1.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BlogSitesiV._1.Data.ModelHarita
{
    public class YorumModel : EntityTypeConfiguration<Yorum>
    {
        public YorumModel()
        {
            //Primary Key
            HasKey(t => t.yorumID);

            //Fields
            Property(t => t.yorumTarih).HasColumnType("datetime2");
            Property(t => t.YorumOnay);
            Property(t => t.yorumResim);

            ToTable("Yorum");

            //Relationship
            HasRequired(t => t.uye).WithMany(z => z.Yorums).HasForeignKey(t => t.uyeID).WillCascadeOnDelete(false);
            HasRequired(t => t.makale).WithMany(z => z.Yorums).HasForeignKey(t => t.makaleID).WillCascadeOnDelete(false);

        }
    }
}