using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Orderde
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "訂單編號")]
        public int Order_number { get; set; }
        public int Game_number { get; set; }
        [Display(Name = "遊戲名稱")]
        public string Game_name { get; set; }
        [Display(Name = "遊戲序號")]
        public Guid Guid { get; set; }
        public string Customer_number { get; set; }

    }
}
