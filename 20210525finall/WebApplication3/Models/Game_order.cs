using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Game_order
    {
        [Key]
        public int Game_number{get;set;}
        public Guid Game_Serial{ get; set; }
    }
}
