using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using System.Web;

namespace BlogSitesiV._1.Data
{
    public class Context : DbContext
    {
        public Context()
            : base("name=DbConnectionString")
        {

        }

        //public DbSet<Uye> UYE { get; set; }
        //public DbSet<Makale> MAKALE { get; set; }
        //public DbSet<Yorum> YORUM { get; set; }
        //public DbSet<Etiket> ETİKET { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
           .Where(type => !String.IsNullOrEmpty(type.Namespace))
           .Where(type => type.BaseType != null && type.BaseType.IsGenericType
                && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }
            base.OnModelCreating(modelBuilder);

        }

        public System.Data.Entity.DbSet<BlogSitesiV._1.Data.Model.Yonetici> Yoneticis { get; set; }

        public System.Data.Entity.DbSet<BlogSitesiV._1.Data.Model.Uye> Uyes { get; set; }

        public System.Data.Entity.DbSet<BlogSitesiV._1.Data.Model.Yorum> Yorums { get; set; }

        public System.Data.Entity.DbSet<BlogSitesiV._1.Data.Model.Makale> Makales { get; set; }

        public System.Data.Entity.DbSet<BlogSitesiV._1.Data.Model.Kategori> Kategoris { get; set; }

        //public System.Data.Entity.DbSet<kocabasOguzhanBlog.Data.Model.Kategori> Kategoris { get; set; }
        //public System.Data.Entity.DbSet<kocabasOguzhanBlog.Data.Model.Makale> Makales { get; set; }
        //public System.Data.Entity.DbSet<kocabasOguzhanBlog.Data.Model.Uye> Uyes { get; set; }
        //public System.Data.Entity.DbSet<kocabasOguzhanBlog.Data.Model.Yonetici> Yoneticis { get; set; }
        //public System.Data.Entity.DbSet<kocabasOguzhanBlog.Data.Model.Yorum> Yorums { get; set; }
    

    }
}