using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSitesiV._1.Data.Model
{
    public class Yonetici
    {
        public int yoneticiID { get; set; }
        public string yoneticiAd { get; set; }
        public string yoneticiSoyad { get; set; }
        public string yoneticiKullanici { get; set; }
        public string yoneticiSifre { get; set; }
    }
}