using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Individual_user_account.Controllers
{
    public class identifyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}