using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
using WebApplication3.Models.Data;

namespace WebApplication3.Access
{
    public class Sale : ISale
    {

        private readonly GameDbContext _context;

        public Sale(GameDbContext context)
        {
            _context = context;

        }
        public List<Salecs> GetSalecs()
        {
            var gamelist = _context.Game_mall.ToList();

            List<Salecs> sales = new List<Salecs>();

            var ga =
                     from s in _context.Orderde
                     group s by s.Game_name into g
                     orderby g.Count() descending 
                     select new Salecs
                     {
                         count = g.Count(),
                         Gamename = g.Key,
                

                     };

            foreach(var row in ga)
            {

                foreach(var row1 in gamelist)
                {
                   
            
                    if (row.Gamename == row1.Game_name)
                    {
                        Salecs sale = new Salecs();
                        sale.count = row.count;
                        sale.Gamename = row.Gamename;
                        sale.price = row.count * row1.Unit_price;
                        sales.Add(sale);
                        break;
                    }
                    
                   
                }



            }
            return sales;

        }


    }
}
