using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TikoClass:DbContext
    {
        public TikoClass() :base("name=kkk")
        {

        }


        public DbSet<player> player { get; set; }
        public DbSet<teams> teams { get; set; }
        public DbSet<priceplayer> prices { get; set; }
        public DbSet<Class1> jns { get; set; }

    }
}
