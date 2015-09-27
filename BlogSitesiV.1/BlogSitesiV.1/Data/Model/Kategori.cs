using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSitesiV._1.Data.Model
{
    public class Kategori
    {
        public int kategoriID { get; set; }
        public string kategoriAd { get; set; }
        public int kategoriAdet { get; set; }
        public string kategoriResim { get; set; }
        public virtual ICollection<Makale> Makales { get; set; }
    }
}