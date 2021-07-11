using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Asscss
{
    public interface IGame_Story
    {
        public List<Game_mall> GetGame_Story();
        public List<Game_Story_Comment> GetGame_Story2();
    }
}
