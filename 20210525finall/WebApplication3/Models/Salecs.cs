using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Salecs
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "已售出")]
        public int count { get; set; }
        [DataType(DataType.Currency)]
        
        public int price { get; set; }
        [Display(Name ="遊戲名稱")]
        public string Gamename { get; set; }
        public int total { get; set; }
    }
}
