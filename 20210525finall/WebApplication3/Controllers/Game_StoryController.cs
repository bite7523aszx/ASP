using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Asscss;
using WebApplication3.Helpers;
using WebApplication3.Models;
using WebApplication3.Models.Data;
using WebApplication3.ViewModel;

namespace WebApplication3.Controllers
{
    public class Game_StoryController : Controller
    {
        private readonly IGame_Story _game_Story;
        private readonly GameDbContext _context;

        public Game_StoryController(IGame_Story game_Story, GameDbContext context)
        {
            _game_Story = game_Story;
            _context = context;
        }
        public IActionResult Index()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }
        public IActionResult Game_Story1()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
            //if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            //{
            //    var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            //    ViewBag.cart = cart;
            //    ViewBag.count = cart.Sum(item => item.Quantity);
            //    ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            //}


            //if (id == null)
            //{
            //    return BadRequest();
            //}
            //Game_mall game_mall = _context.Game_mall.Find(id);
            //Game_mallCommentViewModel game_mallCommentViewModel = new Game_mallCommentViewModel();

            //if (game_mall == null)
            //{
            //    return NotFound();
            //}
            //game_mallCommentViewModel.Comment_Game_number = id.Value;
            //game_mallCommentViewModel.Game_name = game_mall.Game_name;
            //var Comments = _context.Game_mallComments.Where(d => d.Comment_Game_number.Equals(id.Value)).ToList();
            //game_mallCommentViewModel.ListOfComments = Comments;

            //var ratings = _context.Game_mallComments.Where(d => d.Comment_Game_number.Equals(id.Value)).ToList();
            //if (ratings.Count() > 0)
            //{
            //    var ratingSum = ratings.Sum(d => d.Rating);
            //    ViewBag.RatingSum = ratingSum;
            //    var ratingCount = ratings.Count();
            //    ViewBag.RatingCount = ratingCount;
            //}

            //else
            //{
            //    ViewBag.RatingSum = 0;
            //    ViewBag.RatingCount = 0;
            //}

            //var Myobj = "";
            //Myobj = Myobj + _game_Story.GetGame_Story();
            //Myobj = Myobj + game_mallCommentViewModel;
          
        }

        public IActionResult Game_Story2()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story3()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story4()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story5()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story6()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story7()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story8()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story9()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story10()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story11()
        {
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story12()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story13()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story14()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story15()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story16()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story17()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story18()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story19()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story20()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story21()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story22()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story23()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story24()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story25()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story26()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story27()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story28()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story29()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Game_Story30()
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
            return View(_game_Story.GetGame_Story());
        }

    }
}