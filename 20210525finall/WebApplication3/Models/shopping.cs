using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Areas.Identity.Data;


namespace WebApplication3.Models
{
    public class shopping
    {
        public int shoppingId { get; set; }
        [Display(Name = "遊戲名稱")]
        [Required]
        public string Game_name { get; set; }
        [Display(Name = "遊戲種類")]
        [Required]
        public string Game_category { get; set; }
        [Display(Name = "單價")]
        [Required]
        [DataType(DataType.Currency)]
        public int Unit_price { get; set; }
        public int quantity { get; set; }
     
        public string Email { get; set; }
    }
}
