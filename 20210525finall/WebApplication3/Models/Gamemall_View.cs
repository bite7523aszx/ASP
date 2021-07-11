using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Helpers;

namespace WebApplication3.Models
{
    public class Gamemall_View
    {

        public int Game_number { get; set; }

        public string Game_name { get; set; }

        public string Game_category { get; set; }
        [DataType(DataType.Currency)]
        public int Unit_price { get; set; }

        public int quantity { get; set; }
        public Gamemall_View Game1 { get; set; }
        public List<Gamemall_View> Game {get;set; }
        public List<Game_mall> Game_mallCollection { get; set; }

        public string style { get; set; }
        //public List<Gamemall_View> collect()
        //{

        //    Game = new List<Gamemall_View>();
        //    Game.Add(new Gamemall_View {Game_number, quantity });





        //    return Game;
        //}

    }
}
