using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSitesiV._1.Data.Model
{
    public class Uye
    {
        public int uyeID { get; set; }
        public string uyeAd { get; set; }
        public string uyeSoyad { get; set; }
        public string uyeEmail { get; set; }
        public string uyeKullanici { get; set; }
        public string uyeSifre { get; set; }
        public virtual ICollection<Yorum> Yorums { get; set; }
    }
}