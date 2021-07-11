using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;
using WebApplication3.Helpers;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CartController : Controller
    {
        private readonly GameVIewContext _context;

        public CartController(GameVIewContext context)
        {
            _context = context;

        }

        public IActionResult Index()
        {
            ViewBag.str = "數量不能為負";
            Item item = new Item();
            item.Game = new List<Item>();
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart == null)
            {
                return RedirectToAction("index", "check");
            }
            ViewBag.count = cart.Sum(item => item.Quantity);
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Product.Unit_price * item.Quantity);
            foreach (var row in cart)
            {
                if (row.Game_number != 0)
                {
                    Item item1 = new Item();
                    item1.Product = new Game_mall();
                    item1.Game_number = row.Game_number;
                    item1.Product.Game_name = row.Product.Game_name;
                    item1.Product.Game_category = row.Product.Game_category;
                    item1.Product.Unit_price = row.Product.Unit_price;
                    item1.Quantity = row.Quantity;
                    item.Game.Add(item1);
                }
                else if(row.Game_number == 0)
                {

                    Item item1 = new Item();
                    item1.Product = new Game_mall();
                    item1.Game_number = row.Product.Game_number;
                    item1.Product.Game_name = row.Product.Game_name;
                    item1.Product.Game_category = row.Product.Game_category;
                    item1.Product.Unit_price = row.Product.Unit_price;
                    item1.Quantity = row.Quantity;
                    item.Game.Add(item1);


                }
            }

            return View(item);
        }
        [HttpPost]
        public IActionResult Index(Item item)
        {

            int count = 0;
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");

            foreach (var row in item.Game)
            {
                if (row.Quantity < 0)
                {

                    ViewBag.str = "數量不能為負";
                    return RedirectToAction("index","cart");

                }
            }
            foreach (var row in cart)
            {
                
                foreach (var row1 in item.Game)
                {
                 
                    if (row1.Game_number == row.Game_number)
                    {
                        row.Quantity = row1.Quantity;
                        SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                    }
                  
                    if (row1.Game_number == row.Product.Game_number)
                    {
                        row.Quantity = row1.Quantity;
                        SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                    }



                }
            }
            return RedirectToAction("index", "check");
        }
        public IActionResult Google()
        {
            return View();
        }

        private int isExist(int id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.Game_number.Equals(id))
                {
                    return i;
                }
                if (cart[i].Game_number.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }
        public IActionResult Buy(int id)
        {
            int count = 0;
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)//如果我的session不是null,以下的動作就是幫購物車新增一筆資料
            {

                var cart = _context.Game_mall.Where(x => x.Game_number == id);//把資料庫的資料取出
                Item item = new Item();
                item.Game = new List<Item>();
                foreach (var row in cart)
                {
                    Item item1 = new Item();
                    item1.Product = new Game_mall();
                    item1.Game_number = row.Game_number;
                    item1.Product.Game_name = row.Game_name;
                    item1.Product.Game_category = row.Game_category;
                    item1.Product.Unit_price = row.Unit_price;
                    item1.Quantity = item.Quantity;
                    item.Game.Add(item1);

                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", item.Game);//更新session
                //string Action = "Game_Story" + id;

                return RedirectToAction("index", "Cart");
            }

            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null) //如果session不等於0
            {
                var cart1 = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");//取得session

                foreach (var row in cart1)
                {
                    if (row.Game_number == id)//如果我的session有這些資料
                    {
                        row.Quantity = row.Quantity + 1;//就幫我新增一筆
                        SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart1);
                    }
                    else if (row.Product.Game_number == id)//同上
                    {
                        row.Quantity = row.Quantity + 1;
                        SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart1);

                    }
                    else if (row.Game_number != id)//如果沒有該筆料就做count++
                    {
                        count++;
                    }
                    else if (row.Product.Game_number != id)
                    {
                        count++;

                    }
                }
                if (count == cart1.Count)//當我的count等於我的cart的資料筆數，也就是在cart1當中找不到該筆資料，以下的動作就是幫session新增一筆
                {
                    var cart2 = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                    var data1 = _context.Game_mall.Where(x => x.Game_number == id);
                    Item item = new Item();
                    item.Game = new List<Item>();
                    foreach (var row in data1)
                    {
                        Item item1 = new Item();
                        item1.Product = new Game_mall();
                        item1.Game_number = row.Game_number;
                        item1.Product.Game_name = row.Game_name;
                        item1.Product.Game_category = row.Game_category;
                        item1.Product.Unit_price = row.Unit_price;
                        item1.Quantity = item.Quantity;
                        cart2.Add(item1);


                    }
                    SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart2);//更新session



                }

                return RedirectToAction("index", "Cart");
            }
            return RedirectToAction("index", "Cart");
        }
        [HttpPost]
        public IActionResult Buy(Gamemall_View game)
        {

            //Game_mall Game_malls = new Game_mall();
            int id = game.Game_number;
            if (game.quantity < 0)//如果我輸入的數量小於0
            {
                return Content("數量不能為負");
            }
            //Game_mall Game_malls = new Game_mall();
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)//如果我Session等於空也就是購物車沒資料
            {
                if (game.quantity == 0) //如果我的game.quantity等於0
                {
                    List<Item> cart = new List<Item>();
                    cart.Add(new Item { Product = _context.Game_mall.Find(id), Quantity = 1 });//把數量變成1加入session
                    SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);//更新 session

                }
                else//如果不等於0
                {
                    List<Item> cart = new List<Item>();
                    cart.Add(new Item { Product = _context.Game_mall.Find(id), Quantity = game.quantity });//否則就讓session等於我傳回來的數量
                    SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                }
            }
            else//如果我的session不等於0
            {
                List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");//取得session
                int index = isExist(id);
                if (index != -1)
                {
                    if (game.quantity == 0)//如果session裡的game.quantity等於0
                    {
                        cart[index].Quantity++;//就幫session(購物車)增加1
                    }
                    else //如果不等於0就坐累加
                    {


                        cart[index].Quantity = cart[index].Quantity + game.quantity;


                    }
                }
                else
                {
                    if (game.quantity == 0)
                    {
                        cart.Add(new Item { Product = _context.Game_mall.Find(id), Quantity = 1 });

                    }
                    else
                    {
                        cart.Add(new Item { Product = _context.Game_mall.Find(id), Quantity = game.quantity });
                    }
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);

            }
            return RedirectToAction("index", "Game_mallView");
        }

        public IActionResult Remove(int id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("index");
        }
        //public IActionResult stroyaddcart(int id)
        //{
        //    int count = 0;
        //    if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)//如果我的session不是null,以下的動作就是幫購物車新增一筆資料
        //    {

        //        var cart = _context.Game_mall.Where(x => x.Game_number == id);//把資料庫的資料取出
        //        Item item = new Item();
        //        item.Game = new List<Item>();
        //        foreach (var row in cart)
        //        {
        //            Item item1 = new Item();
        //            item1.Product = new Game_mall();
        //            item1.Game_number = row.Game_number;
        //            item1.Product.Game_name = row.Game_name;
        //            item1.Product.Game_category = row.Game_category;
        //            item1.Product.Unit_price = row.Unit_price;
        //            item1.Quantity = 1;
        //            item.Game.Add(item1);

        //        }
        //        SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", item.Game);//更新session
        //                                                                              //string Action = "Game_Story" + id;
        //        return RedirectToAction("Game_Story" + id, "Game_Story");

        //    }

        //    if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null) //如果session不等於0
        //    {
        //        var cart1 = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");//取得session

        //        foreach (var row in cart1)
        //        {
        //            if (row.Game_number == id)//如果我的session有這些資料
        //            {
        //                row.Quantity = row.Quantity + 1;//就幫我新增一筆
        //                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart1);
        //            }
        //            else if (row.Product.Game_number == id)//同上
        //            {
        //                row.Quantity = row.Quantity + 1;
        //                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart1);

        //            }
        //            else if (row.Game_number != id)//如果沒有該筆料就做count++
        //            {
        //                count++;
        //            }
        //            else if (row.Product.Game_number != id)
        //            {
        //                count++;

        //            }
        //        }
        //        if (count == cart1.Count)//當我的count等於我的cart的資料筆數，也就是在cart1當中找不到該筆資料，以下的動作就是幫session新增一筆
        //        {
        //            var cart2 = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
        //            var data1 = _context.Game_mall.Where(x => x.Game_number == id);
        //            Item item = new Item();
        //            item.Game = new List<Item>();
        //            foreach (var row in data1)
        //            {
        //                Item item1 = new Item();
        //                item1.Product = new Game_mall();
        //                item1.Game_number = row.Game_number;
        //                item1.Product.Game_name = row.Game_name;
        //                item1.Product.Game_category = row.Game_category;
        //                item1.Product.Unit_price = row.Unit_price;
        //                item1.Quantity = 1;
        //                cart2.Add(item1);


        //            }
        //            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart2);//更新session



        //        }

        //    }
        //    return RedirectToAction("Game_Story" + id, "Game_Story");
        //}
        [HttpPost]
        public IActionResult stroyaddcart(Gamemall_View game_Mall)
        {

                int count = 0;
       
                if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)//如果我的session不是null,以下的動作就是幫購物車新增一筆資料
                {
                    if (game_Mall.quantity == 0)
                    {
                        var cart = _context.Game_mall.Where(x => x.Game_number == game_Mall.Game_number);//把資料庫的資料取出
                        Item item = new Item();
                        item.Game = new List<Item>();
                        foreach (var row in cart)
                        {
                            Item item1 = new Item();
                            item1.Product = new Game_mall();
                            item1.Game_number = row.Game_number;
                            item1.Product.Game_name = row.Game_name;
                            item1.Product.Game_category = row.Game_category;
                            item1.Product.Unit_price = row.Unit_price;
                            item1.Quantity = 1;
                            item.Game.Add(item1);

                        }
                        SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", item.Game);//更新session
                                                                                              //string Action = "Game_Story" + id;
                        return RedirectToAction("Game_Story" + game_Mall.Game_number, "Game_Story");
                    }
                    else if(game_Mall.quantity != 0)
                    {
                        var cart = _context.Game_mall.Where(x => x.Game_number == game_Mall.Game_number);//把資料庫的資料取出
                        Item item = new Item();
                        item.Game = new List<Item>();
                        foreach (var row in cart)
                        {
                            Item item1 = new Item();
                            item1.Product = new Game_mall();
                            item1.Game_number = row.Game_number;
                            item1.Product.Game_name = row.Game_name;
                            item1.Product.Game_category = row.Game_category;
                            item1.Product.Unit_price = row.Unit_price;
                            item1.Quantity = game_Mall.quantity;
                            item.Game.Add(item1);

                        }
                        SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", item.Game);//更新session
                                                                                              //string Action = "Game_Story" + id;
                        return RedirectToAction("Game_Story" + game_Mall.Game_number, "Game_Story");



                    }
                }
            
            
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") != null) //如果session不等於0
            {
                var cart1 = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");//取得session

                foreach (var row in cart1)
                {
                    if(game_Mall.quantity!=0)
                    {
                        if (row.Game_number == game_Mall.Game_number)//如果我的session有這些資料
                        {
                            row.Quantity = game_Mall.quantity+ row.Quantity;//就幫我新增一筆
                            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart1);
                        }
                        else if (row.Product.Game_number == game_Mall.Game_number)//同上
                        {
                            row.Quantity = game_Mall.quantity+ row.Quantity;
                            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart1);

                        }
                        else if (row.Game_number != game_Mall.Game_number)//如果沒有該筆料就做count++
                        {
                            count++;
                        }
                        else if (row.Product.Game_number != game_Mall.Game_number)
                        {
                            count++;


                        }
                    }
                    else if(game_Mall.quantity == 0)
                    {
                        if (row.Game_number == game_Mall.Game_number)//如果我的session有這些資料
                        {
                            row.Quantity = row.Quantity + 1;//就幫我新增一筆
                            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart1);
                        }
                        else if (row.Product.Game_number == game_Mall.Game_number)//同上
                        {
                            row.Quantity = row.Quantity + 1;
                            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart1);

                        }
                        else if (row.Game_number != game_Mall.Game_number)//如果沒有該筆料就做count++
                        {
                            count++;
                        }
                        else if (row.Product.Game_number != game_Mall.Game_number)
                        {
                            count++;


                        } 
                    }
                }
                if (count == cart1.Count)//當我的count等於我的cart的資料筆數，也就是在cart1當中找不到該筆資料，以下的動作就是幫session新增一筆
                {
                    if (game_Mall.quantity == 0)
                    {
                        var cart2 = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                        var data1 = _context.Game_mall.Where(x => x.Game_number == game_Mall.Game_number);
                        Item item = new Item();
                        item.Game = new List<Item>();
                        foreach (var row in data1)
                        {
                            Item item1 = new Item();
                            item1.Product = new Game_mall();
                            item1.Game_number = row.Game_number;
                            item1.Product.Game_name = row.Game_name;
                            item1.Product.Game_category = row.Game_category;
                            item1.Product.Unit_price = row.Unit_price;
                            item1.Quantity = 1;
                            cart2.Add(item1);
                        }
                        SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart2);//更新session
                    }
                    else if(game_Mall.quantity != 0)
                    {
                        var cart2 = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                        var data1 = _context.Game_mall.Where(x => x.Game_number == game_Mall.Game_number);
                     
                        Item item = new Item();
                        item.Game = new List<Item>();
                        foreach (var row in data1)
                        {
                            Item item1 = new Item();
                            item1.Product = new Game_mall();
                            item1.Game_number = row.Game_number;
                            item1.Product.Game_name = row.Game_name;
                            item1.Product.Game_category = row.Game_category;
                            item1.Product.Unit_price = row.Unit_price;
                            item1.Quantity = 0;
                            cart2.Add(item1);                         //cart2.Add(item1);
                        }
                        SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart2);//更新session
                        var cart3 = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                        foreach (var row in cart3)
                        {
                            if (row.Game_number == game_Mall.Game_number)
                            {
                                row.Quantity = row.Quantity + game_Mall.quantity;
                                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart3);

                            }
                        }

                    }
                }

            }
            return RedirectToAction("Game_Story" + game_Mall.Game_number, "Game_Story");
        }
    }
}