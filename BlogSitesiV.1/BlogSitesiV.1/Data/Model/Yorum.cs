using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSitesiV._1.Data.Model
{
    public class Yorum
    {
        public int yorumID { get; set; }
        public DateTime yorumTarih { get; set; }
        public Boolean YorumOnay { get; set; }
        public string yorumResim { get; set; }
        public Makale makale { get; set; }
        public Uye uye { get; set; }
        public int makaleID { get; set; }
        public int uyeID { get; set; }
    }
}