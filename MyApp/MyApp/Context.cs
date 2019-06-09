using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
   public class Context:DbContext
    {

        public Context() : base("name=conn")
        {

        }

        public DbSet<Cars1> Crs { get; set; }
    }
}
