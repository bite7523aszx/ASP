using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class SaveValue
    {
        public int Mycard { get; set; }
        public int CreditCard { get; set; }
        public int SavePointMethod { get; set; }
        public string Email{ get; set; }
        public object Emails { get; internal set; }
    }
}
