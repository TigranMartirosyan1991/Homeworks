using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Context context = new Context();
            List<Cars1> carsList = new List<Cars1>() {
                new Cars1{ ID=1,Model="BMW",year="2012"},
                new Cars1{ ID=2,Model="BMW",year="2015"},
                new Cars1{ ID=3,Model="BMW",year="2016"},
            };

            carsList.ForEach(a =>
            {
                context.Crs.Add(a);
                context.SaveChanges();


            });

        }
    }
}
