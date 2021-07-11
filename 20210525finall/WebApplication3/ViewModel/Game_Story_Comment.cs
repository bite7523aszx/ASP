using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.ViewModel;

namespace WebApplication3.Models
{
    public class Game_Story_Comment : Game_mall
    {
        public Game_mall game_mall { get; set; }
        public Game_mallCommentViewModel game_mallCommentViewModel { get; set; }
    }
}
