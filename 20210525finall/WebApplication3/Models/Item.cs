using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Item
    {
        public Game_mall Product { get; set; }
        [Range(1, 100)]
        public int Quantity { get; set; }
        public int Game_number { get; set; }
        public List<Item> Game { get; set; }
    }
}
