using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.ViewModel
{
    public class Game_mallCommentViewModel
    {
        public string Game_name { get; set; }
        public List<Game_mallComment> ListOfComments { get; set; }
        public string Comment { get; set; }
        public int Comment_Game_number { get; set; }
        public int Rating { get; set; }
        public Game_mall game_mall { get; set; }

    }
}
