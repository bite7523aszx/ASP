using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Game_mallComment
    {
        public int Id { get; set; }
        public string Comments { get; set; }
        public DateTime PublishedDate { get; set; }
        public int Comment_Game_number { get; set; }
        public Game_mall Game_malls { get; set; }
        public int Rating { get; set; }
    }
}
