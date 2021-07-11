using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
       
{
    public class Customer_Profile
    {
        [Key]
        [Display(Name = "客戶編號")]
        public int Customer_number { get; set; }
        //[Display(Name = "客戶名稱")]
        public string Customer_name { get; set; }
        //[Display(Name = "性別")]       
        //[StringLength(1)]
        //[Required(ErrorMessage = "填男或女")]
        public string Gender { get; set; }
        //[Display(Name = "電子信箱")]
        public string Email { get; set; }
        //[Display(Name = "帳號")]
        //[StringLength(50)]
        //[RegularExpression(@"^[a-zA-Z""'\s-]*$")]
        //[Required]       
        public string Account { get; set; }
        //[Display(Name = "密碼")]
        //[StringLength(50)]
        //[RegularExpression(@"^[a-zA-Z""'\s-]*$")]
        //[Required]
        public string Password { get; set; }
        //[Display(Name = "地址")]
        public string Address { get; set; }
        //[Display(Name = "遊戲點數")]
        public int  Game_point { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
