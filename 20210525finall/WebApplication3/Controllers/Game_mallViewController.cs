using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApplication3.Access;
using WebApplication3.Asscss;
using WebApplication3.Data;
using WebApplication3.Helpers;
using WebApplication3.Migrations.User;
using WebApplication3.Models;
using WebApplication3.ViewModel;

namespace WebApplication3.Controllers
{
    public class Game_mallViewController : Controller
    {
        private readonly GameVIewContext _context;
        private readonly sqlDataAcess _sqlDataAcess;
        private readonly IGame_Story _game_Story;


        public Game_mallViewController(GameVIewContext context,sqlDataAcess sqlDataAcess, IGame_Story game_Story)
        {
            _context = context;
            _sqlDataAcess = sqlDataAcess;
            _game_Story = game_Story;
        }

        // GET: Game_mallView
        public async Task<IActionResult> Index()
        {
           ViewBag.qu= new List<int>() { 1, 2, 3, 4 };
            var count = 0;
            var USER = User.Identity.Name;
            if (USER != null)
            {
                string sql_data1 = @"select Game_point from Customer_Profile where Email='" + USER + "' ";
                var data1 = _sqlDataAcess.LoadData<Customer_Profile>(sql_data1);
                 if (data1.Count != 0)
                {
                    foreach (var row in data1)
                    {


                        ViewBag.Game_point = "儲值金額:"+row.Game_point;

                    }


                }
            }
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null)
            {
                
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.count = cart.Sum(item => item.Quantity);
                ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            }
         
            var Orderdes = _context.Orderde.ToList();
            var gamemalls =_context.Game_mall.ToList();
            List<Game_mall> game_Malls = new List<Game_mall>();
            var Top10 = from order in Orderdes group order by order.Game_number into top10 orderby top10.Count() descending select new Salecs { id = top10.Key, count = top10.Count()}; 
            foreach(var row1 in Top10)
            {
                foreach(var row in gamemalls)
                {

                    if(row1.id==row.Game_number)
                    {
                        Game_mall game_ = new Game_mall();
                        game_.Game_number = row.Game_number;
                        game_.Game_name = row.Game_name;
                        game_.Game_category = row.Game_category;
                        game_.Unit_price = row.Unit_price;                       
                        game_Malls.Add(game_);
                     
                        break;
                    }
                    if (game_Malls.Count == 10)
                    {
                        break;
                    }
                }

            }
            ViewBag.gamemall = game_Malls;

            //foreach (var row2 in game_Malls)
            //{
            //    Gamemall_View games = new Gamemall_View();
            //    games.Unit_price = row2.Unit_price;
            //    games.Game_category = row2.Game_category;

            //    foreach (var row in Top10)
            //    {
            //        int count1 = 0;
            //        int count2 = 0;
            //        games.Game_number = row.key;
            //        games.quantity = row.cnt;

            //        foreach (var row1 in row.Gamename)
            //        {
            //            if (count > 1)
            //            {
            //                break;
            //            }

            //            games.Game_name = row1.Game_name;
            //            count1++;
            //        }
            //        count2++;
            //        if(count2 >1 )
            //        {
            //            break;
            //        }

            //    }
            //    gamemall.Add(games);
            //}
          
            //foreach (var order)
            //{ }
            string sql_data = @"select*from Game_mall;";
            var data2 = _sqlDataAcess.LoadData<Gamemall_View>(sql_data);
            return View(/*await _context.Game_mall.ToListAsync()*/ data2);
        }

        public IActionResult Casual()
        {
            return View(_game_Story.GetGame_Story());
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Strategy()
        {
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Adventure()
        {
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Action()
        {
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Simulation()
        {
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult Racing()
        {
            return View(_game_Story.GetGame_Story());
        }

        public IActionResult indexview()
        {
            return View();
        }

        [Authorize]
        public IActionResult Storedvalue()
        {
            var USER = User.Identity.Name;
            string sql_data1 = @"select Game_point from Customer_Profile where Email='" + USER + "' ";
            var data1 = _sqlDataAcess.LoadData<Customer_Profile>(sql_data1);

            foreach (var row in data1)
            {


                ViewBag.Game_point = "儲值金額:" + row.Game_point;

            }


            return View();
        }
        [HttpPost]
        public IActionResult Storedvalue(SaveValue saveValue)
        {
            if (saveValue.SavePointMethod == 1)//如果我選擇用GameCard儲值我的SavePointMethod就等於1
            {
               

                return RedirectToAction("Mycard");
            }
            else if (saveValue.SavePointMethod == 2)
            {


                return View();
            }
            return View();
        }
        public IActionResult Mycard()
        {
            var USER = User.Identity.Name;
            string sql_data1 = @"select Game_point from Customer_Profile where Email='" + USER + "' ";
            var data1 = _sqlDataAcess.LoadData<Customer_Profile>(sql_data1);

            foreach (var row in data1)
            {


                ViewBag.Game_point = "儲值金額:" + row.Game_point;

            }


            //string sql_data = @"select UserName from AspNetUsers where UserName='" + user + "'";



            return View();
        }
        
        [HttpPost]
        public IActionResult Mycard(SaveValue saveValue)
        {
            string sql_data1 = @"select*from Customer_Profile where Email='" + saveValue.Email + "' ";//看進來的Email有沒有在顧客資料表
            var data = _sqlDataAcess.LoadData<Customer_Profile>(sql_data1);
            if (data.Count == 0)//如果該E-mail沒在顧客資料表中就幫他新增
            {
                Customer_Profile Customer = new Customer_Profile();
                Customer.Email= saveValue.Email;
                Customer.Game_point = saveValue.SavePointMethod;
                string sql_data = @"insert into Customer_Profile(Email,Game_point)values(@Email,@Game_point);";
                _sqlDataAcess.SaveData<Customer_Profile>(sql_data, Customer);
                return RedirectToAction("index");
            }
            else if (data.Count > 0)//如果再就把顧客的點數取出相加在丟回去
            {
                string sql_data2 = @"select Game_point from Customer_Profile where Email='" + saveValue.Email + "' ";
                var data1 = _sqlDataAcess.LoadData<Customer_Profile>(sql_data2);
                Customer_Profile Game_point = new Customer_Profile();
                foreach (var row in data1)
                {
                    Game_point.Game_point = row.Game_point + saveValue.SavePointMethod;
                }

                string sql_data3 = @"update Customer_Profile set Game_point=@Game_point where Email='" + saveValue.Email + "'";
                _sqlDataAcess.SaveData<Customer_Profile>(sql_data3, Game_point);
                return RedirectToAction("index");
            }
            return View();
        }
        public IActionResult Search(string Gamename)
        {
            //var type = from y in _context.Game_mall.Where(y => y.Game_category ==ty) select y;
            var searchgamename = from s in _context.Game_mall.Where(s => s.Game_name == Gamename) select s;

                return View("index", searchgamename);

        }

        public void Game_order()
        {
            string sql_data1 = @"select*from Game_mall;";
            var data1 = _sqlDataAcess.LoadData<Game_mall>(sql_data1);
            foreach (var row in data1)
            {
                Game_order Gameorder = new Game_order();
                Guid g = Guid.NewGuid();
                Gameorder.Game_number = row.Game_number;
                Gameorder.Game_Serial = g;
                string sql_data = @"insert into Game_order(Game_number,Game_Serial)values(@Game_number,@Game_Serial);";
                _sqlDataAcess.SaveData<Game_order>(sql_data, Gameorder);
            }

        }



        //public IActionResult Savepoint()
        //{




        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Savepoint(Savepoint savepoint)
        //{
        //    Guid g = Guid.NewGuid();
        //    Savepoint point = new Savepoint();
        //    point.Game_Serial_number = g;
        //    point.Game_point = savepoint.Game_point;
        //    string sql_data = @"insert into Game_Serial(Game_Serial_number,Game_point)values(@Game_Serial_number,@Game_point);";
        //    _sqlDataAcess.SaveData<Savepoint>(sql_data, point);

        //    return View();
        //}


        //// GET: Game_mallView/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var game_mall = await _context.Game_mall
        //        .FirstOrDefaultAsync(m => m.Game_number == id);
        //    if (game_mall == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(game_mall);
        //}

        //// GET: Game_mallView/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Game_mallView/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Game_number,Game_name,Game_category,Unit_price,Listing_date")] Game_mall game_mall)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(game_mall);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(game_mall);
        //}

        //// GET: Game_mallView/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var game_mall = await _context.Game_mall.FindAsync(id);
        //    if (game_mall == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(game_mall);
        //}

        //// POST: Game_mallView/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Game_number,Game_name,Game_category,Unit_price,Listing_date")] Game_mall game_mall)
        //{
        //    if (id != game_mall.Game_number)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(game_mall);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!Game_mallExists(game_mall.Game_number))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(game_mall);
        //}

        //// GET: Game_mallView/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var game_mall = await _context.Game_mall
        //        .FirstOrDefaultAsync(m => m.Game_number == id);
        //    if (game_mall == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(game_mall);
        //}

        //// POST: Game_mallView/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var game_mall = await _context.Game_mall.FindAsync(id);
        //    _context.Game_mall.Remove(game_mall);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool Game_mallExists(int id)
        //{
        //    return _context.Game_mall.Any(e => e.Game_number == id);
        //}
    }
}
