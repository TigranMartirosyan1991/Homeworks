using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           TikoClass conn = new TikoClass();
            List<player> players = new List<player>()
            {
                new player { id =1,name = "Hazard",year = "1990", nationality ="Belgium",position = "Midfielder",PlaerId=1,shirtnumber =10 },
                new player { id =2,name = "Messi",year = "1987",nationality = "Argentina",position = "Forward",PlaerId=2, shirtnumber =10 },
                new player { id =3,name = "Ronaldo",year = "1985",nationality = " Portugal", position = "Forward",PlaerId=3,shirtnumber =7 },
                new player { id =4,name = "Pogba",year = "1988",nationality = "France", position = "Midfielder",PlaerId=4,shirtnumber =6 },
                new player { id =5,name = "Isko",year = "1992",nationality = "Spain", position = "Midfielder ",PlaerId=1,shirtnumber =22 },
                new player { id =6,name = "Kane",year = "1993",nationality = "England", position = "Forward",PlaerId=5,shirtnumber =9 },
                new player { id =7,name = "Kross",year = "1989",nationality ="Germany", position = "Midfielder",PlaerId=1,shirtnumber =8 },
                new player { id =8,name = "Buffon",year = "1981",nationality = "Italy",position = "Goalkeeper",PlaerId=6,shirtnumber = 1},
                new player { id =9,name = "Laporte",year ="1994",nationality = "Frace",position = "Defender",PlaerId=7,shirtnumber = 14},
            };
            List<teams> team = new List<teams>()
            {
                new teams {id = 1,name = "Real Madrid",country = "Spain",stadium = "Santiago Bernabeu"},
                new teams {id = 2,name = "FC Barcelona",country = "Spain",stadium = "Camp Nou"},
                new teams {id = 3,name = "Juventus",country = "Italy",stadium = "Juventus Stadium"},
                new teams {id = 4,name = "Manchester United",country = "England",stadium = "Old Trafford"},
                new teams {id = 5,name = "Tottenham Hotspur",country = "England",stadium = "Tottenham Hotspur Stadium"},
                new teams {id = 6,name = "PSG",country = "Frace",stadium = "Parc des Princes"},
                new teams {id = 7,name = "Manchester City",country = "England",stadium = "Etihad Stadium",},
            };
            List<priceplayer> price = new List<priceplayer>()
            {
                new priceplayer {id = 1,price = "130000000$"},
                new priceplayer {id = 2,price = "180000000$"},
                new priceplayer {id = 3,price = "115000000$"},
                new priceplayer {id = 4,price = "95000000$"},
                new priceplayer {id = 5,price = "75000000$"},
                new priceplayer {id = 6,price = "10000000$"},
                new priceplayer {id = 7,price = "55000000$"},
                new priceplayer {id = 8,price = "25000000$"},
                new priceplayer {id = 9,price = "90000000$"},
            };
            players.ForEach(Item =>
            {
                conn.player.Add(Item);
                conn.SaveChanges();
            });
            team.ForEach(Item =>
            {
                conn.teams.Add(Item);
                conn.SaveChanges();
            });
            price.ForEach(Item =>
            {
                conn.prices.Add(Item);//harc
                conn.SaveChanges();//harc
            });
         var res = (from a in team
                       join b in players on a.id equals b.PlaerId
                       select new { id=a.id,nme = a.name, stad = a.stadium, contry = a.country, nm = b.name, pos = b.position }).ToList();

            List<Class1> lst = new List<Class1>();
            foreach (var Item in res)
            {
                Class1 cs = new Class1() { id=Item.id,nme = Item.nme, stad = Item.stad, contry = Item.contry, nm = Item.nm, pos = Item.pos };
                lst.Add(cs);


            }

            lst.ForEach(Item =>
            {
                conn.jns.Add(Item);
                conn.SaveChanges();

            });
          


             


            //foreach (var item in res)
            //{
            //    Console.WriteLine(item.nm+"    "+item.nme+"   "+item.pos+"   "+item.stad+"   "+item.contry);
            //}
        }
    }
}
