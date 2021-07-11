using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Order
    {
        [Key]
        [Display(Name = "訂單編號")]
        public int Order_number { get; set; }
        [Display(Name = "訂單日期")]
        public DateTime Order_date { get; set; }
        [Display(Name = "電子郵件")]
        public string Customer_number { get; set; }
        [Display(Name = "消費金額")]
        [DataType(DataType.Currency)]
        public decimal Total { get; set; }


        public Customer_Profile Customer_Profile { get; set; }
        public ICollection<Purchase_quantitycs> Purchase_quantitycss { get; set; }
    }
}
