using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models.Data;

namespace WebApplication3.Models
{
    public class Game_mall
    {
        [Key]
        [Display(Name = "遊戲編號")]
        [Required]
        public int Game_number { get; set; }
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
        [Display(Name = "上市日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy年MM月dd日}")]
        [Required]
        public DateTime Listing_date{get;set;}
        public ICollection<Purchase_quantitycs> Purchase_quantitycss { get; set; }
        public ICollection<Game_mallComment> Game_mallComments { get; set; }
    }
}
