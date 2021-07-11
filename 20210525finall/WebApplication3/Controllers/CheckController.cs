using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Access;
using WebApplication3.Data;
using WebApplication3.Helpers;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CheckController : Controller
    {
        private readonly GameVIewContext _context;
        private readonly sqlDataAcess _sqlDataAcess;

        public CheckController(GameVIewContext context, sqlDataAcess sqlDataAcess)
        {
            _context = context;
            _sqlDataAcess = sqlDataAcess;

        }
        [Authorize]
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart == null)
            {

                return RedirectToAction("index", "Game_mallView");


            }
            ViewBag.cart = cart;
            ViewBag.count = cart.Sum(item => item.Quantity);
            ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);

            return View();
        }

        public IActionResult check()//把資料從Game_mall點數拿出來扣
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.count = cart.Sum(item => item.Quantity);
            ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            var user = User.Identity.Name;
            int total = ViewBag.total;
            Order order = new Order();
            {
                order.Customer_number = user;
                order.Order_date = DateTime.Now;
                order.Total = ViewBag.total;
            }
            _context.Order.Add(order);
            _context.SaveChanges();
            string sql_data1 = @"select Game_point from Customer_Profile where Email='" + user + "' ";//下語法把資料拿出來
            var data1 = _sqlDataAcess.LoadData<Customer_Profile>(sql_data1);//把資料一筆一筆變成串列
            if (data1.Count==0)
            {
                return RedirectToAction("index", "Game_mallView");
            }
            foreach (var row in data1)//一筆一筆讀取出來
            {
                Customer_Profile point = new Customer_Profile();
                point.Game_point = row.Game_point - total;//扣款


                if (point.Game_point > 0)
                {
                    string sql_data3 = @"update Customer_Profile set Game_point=@Game_point where Email='" + user + "'";
                    _sqlDataAcess.SaveData<Customer_Profile>(sql_data3, point);//再存回去
                }
                else
                {
                    return RedirectToAction("Storedvalue","Game_mallView");
                }
            }
            //var data = _sqlDataAcess.LoadData<Orderde>(sql_data);
            foreach (var row in cart)
            {
                if (row.Quantity == 1)
                {
                    if (row.Product.Game_number != 0)
                    {

                        Orderde orderde = new Orderde();
                        orderde.Order_number = order.Order_number;
                        orderde.Game_number = row.Product.Game_number;
                        orderde.Game_name = row.Product.Game_name;
                        orderde.Guid = Guid.NewGuid();
                        orderde.Customer_number = user;
                        string sql_data = @"insert into Orderde(Order_number,Game_number,Game_name,Guid,Customer_number)values(@Order_number,@Game_number,@Game_name,@Guid,@Customer_number);";
                        _sqlDataAcess.SaveData<Orderde>(sql_data, orderde);
                    }
                    else if (row.Product.Game_number == 0)
                    {

                        Orderde orderde = new Orderde();
                        orderde.Order_number = order.Order_number;
                        orderde.Game_number = row.Game_number;
                        orderde.Game_name = row.Product.Game_name;
                        orderde.Guid = Guid.NewGuid();
                        orderde.Customer_number = user;
                        string sql_data = @"insert into Orderde(Order_number,Game_number,Game_name,Guid,Customer_number)values(@Order_number,@Game_number,@Game_name,@Guid,@Customer_number);";
                        _sqlDataAcess.SaveData<Orderde>(sql_data, orderde);
                    }

                }
                else if (row.Quantity > 1)
                {
                    if (row.Product.Game_number != 0)
                    {
                        for (var i = 1; i <= row.Quantity; i++)
                        {

                            string sql_data = @"insert into Orderde(Order_number,Game_number,Game_name,Guid,Customer_number)values(@Order_number,@Game_number,@Game_name,@Guid,@Customer_number);";
                            Orderde orderde = new Orderde();
                            orderde.Order_number = order.Order_number;
                            orderde.Game_number = row.Product.Game_number;
                            orderde.Game_name = row.Product.Game_name;
                            orderde.Guid = Guid.NewGuid();
                            orderde.Customer_number = user;
                            _sqlDataAcess.SaveData<Orderde>(sql_data, orderde);


                        }
                    }
                    if (row.Product.Game_number == 0)
                    {
                        for (var i = 1; i <= row.Quantity; i++)
                        {

                            string sql_data = @"insert into Orderde(Order_number,Game_number,Game_name,Guid,Customer_number)values(@Order_number,@Game_number,@Game_name,@Guid,@Customer_number);";
                            Orderde orderde = new Orderde();
                            orderde.Order_number = order.Order_number;
                            orderde.Game_number = row.Game_number;
                            orderde.Game_name = row.Product.Game_name;
                            orderde.Guid = Guid.NewGuid();
                            orderde.Customer_number = user;
                            _sqlDataAcess.SaveData<Orderde>(sql_data, orderde);


                        }
                    }
                }
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", null);
            return RedirectToAction("Order");

        }
        [Authorize]
        public IActionResult Order()
        {
            var user = User.Identity.Name;
            if (user != null)
            {
                string sql_data1 = @"select Game_point from Customer_Profile where Email='" + user + "' ";
                var data1 = _sqlDataAcess.LoadData<Customer_Profile>(sql_data1);
                if (data1.Count == 0)
                {

                    return View();
                }
                else if (data1.Count != 0)
                {
                    foreach (var row in data1)
                    {
                        ViewBag.Game_point = "儲值金額:" + row.Game_point;
                    }
                }
            }
            var reslut = from s in _context.Order.Where(s => s.Customer_number == user).OrderByDescending(y=>y.Order_number)   select s  ;
            return View(reslut);

        }
        [Authorize]
        public IActionResult Details(int? id)
        {
            var user = User.Identity.Name;

            if (user != null)
            {
                string sql_data1 = @"select Game_point from Customer_Profile where Email='" + user + "' ";
                var data1 = _sqlDataAcess.LoadData<Customer_Profile>(sql_data1);
                if (data1.Count == 0)
                {

                    return View();
                }
                else if (data1.Count != 0)
                {
                    foreach (var row in data1)
                    {


                        ViewBag.Game_point = "儲值金額:" + row.Game_point;

                    }


                }
            }
            if (user == null)
            {
                return RedirectToAction("Order");
            }

            //var order = from s in  _context.Orderde.Where(s => s.Order_number == id) select s;

            string sql_data2 = @"select Order_number,Game_name,Guid from Orderde where Order_number=" + id;
            var data2 = _sqlDataAcess.LoadData<Orderde>(sql_data2);//把資料一筆一筆讀取出來
            //List<Orderde> orderde = new List<Orderde>();
            //foreach (var row in data2)
            //{
            //    Orderde orderde1 = new Orderde();
            //    orderde1.Order_number = row.Order_number;
            //    orderde1.Game_name = row.Game_name;
            //    orderde1.Guid = row.Guid;

            //    orderde.Add(orderde1);
            //}

            return View(data2);
        }
        public IActionResult myorder(int? id)
        {
            var user = User.Identity.Name;
            var result = from s in _context.Orderde.Where(y => y.Customer_number == user).GroupBy(g => g.Order_number) select s.Max();
            return View();
        }
    }
}
