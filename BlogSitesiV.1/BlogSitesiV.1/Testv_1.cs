using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogSitesiV._1
{
    public class Testv_1
    {
         Database.SetInitializer<Context>(new CreateDatabaseIfNotExists<Context>());
            using (var context = new Context())
            {}
    }
}