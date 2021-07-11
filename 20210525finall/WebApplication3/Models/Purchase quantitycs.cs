using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Purchase_quantitycs
    {
        [Key]
        public int Order_number { get; set; }
        public int Game_number { get; set; }
        [Display(Name = "數量")]
        [Required] /*未設定條件約束購買數量必須大於零*/
        public int Quantity { get; set; }

        public Order Order { get; set; }

        public Game_mall Game_mall { get; set; }
    }
}
