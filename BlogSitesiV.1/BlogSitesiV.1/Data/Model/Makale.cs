using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSitesiV._1.Data.Model
{
    public class Makale
    {
        public int makaleID { get; set; }
        public string makaleBaslik { get; set; }
        public string makaleOzet { get; set; }
        public string makaleIcerik { get; set; }
        public string makaleResim { get; set; }
        public int makaleOkunma { get; set; }
        public int makaleYorumSayisi { get; set; }
        public Kategori kategori { get; set; }
        public int kategoriID { get; set; }
        public virtual ICollection<Yorum> Yorums { get; set; }
    }
}