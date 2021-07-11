using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Access;
using WebApplication3.Models;
using WebApplication3.Models.Data;

namespace WebApplication3.Controllers
{
    public class SaleController : Controller
    { 
        public ISale _sale { get; set; }

        public SaleController(ISale sale)
        {
            _sale = sale;
        }
        public IActionResult Index()
        {
            
            ViewBag.total = _sale.GetSalecs().Sum(item => item.price);

            return View(_sale.GetSalecs());
        }
    }
}
