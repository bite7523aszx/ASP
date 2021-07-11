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
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class Game_mallController : Controller
    {

        private readonly GameVIewContext _context;

        public Game_mallController(GameVIewContext context)
        {
            _context = context;

        }

        [Authorize]
        // GET: Game_mall
        // 帳號 abc@gmail.com  密碼 abc123A#
        public async Task<IActionResult> Index()
        {
            if (User.Identity.Name != "abc@gmail.com")
            {
                return Content("無存取權限");
            }
            return View(await _context.Game_mall.ToListAsync());
        }
        // GET: Game_mall/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (User.Identity.Name != "abc@gmail.com")
            {
                return Content("無存取權限");
            }

            if (id == null)
            {
                return NotFound();
            }

            var game_mall = await _context.Game_mall
                .FirstOrDefaultAsync(m => m.Game_number == id);
            if (game_mall == null)
            {
                return NotFound();
            }

            return View(game_mall);
        }

        // GET: Game_mall/Create
        public IActionResult Create()
        {
            if (User.Identity.Name != "abc@gmail.com")
            {
                return Content("無存取權限");
            }
            return View();
        }

        // POST: Game_mall/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Game_number,Game_name,Game_category,Unit_price,Listing_date")] Game_mall game_mall)
        {
            if (User.Identity.Name != "abc@gmail.com")
            {
                return Content("無存取權限");
            }
            if (ModelState.IsValid)
            {
                _context.Add(game_mall);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(game_mall);
        }

        // GET: Game_mall/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (User.Identity.Name != "abc@gmail.com")
            {
                return Content("無存取權限");
            }
            if (id == null)
            {
                return NotFound();
            }

            var game_mall = await _context.Game_mall.FindAsync(id);
            if (game_mall == null)
            {
                return NotFound();
            }
            return View(game_mall);
        }

        // POST: Game_mall/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Game_number,Game_name,Game_category,Unit_price,Listing_date")] Game_mall game_mall)
        {
            if (User.Identity.Name != "abc@gmail.com")
            {
                return Content("無存取權限");
            }
            if (id != game_mall.Game_number)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(game_mall);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Game_mallExists(game_mall.Game_number))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(game_mall);
        }

        // GET: Game_mall/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (User.Identity.Name != "abc@gmail.com")
            {
                return Content("無存取權限");
            }
            if (id == null)
            {
                return NotFound();
            }

            var game_mall = await _context.Game_mall
                .FirstOrDefaultAsync(m => m.Game_number == id);
            if (game_mall == null)
            {
                return NotFound();
            }

            return View(game_mall);
        }

        // POST: Game_mall/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (User.Identity.Name != "abc@gmail.com")
            {
                return Content("無存取權限");
            }
            var game_mall = await _context.Game_mall.FindAsync(id);
            _context.Game_mall.Remove(game_mall);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [Authorize(Roles ="sa")]
        private bool Game_mallExists(int id)
        {
            return _context.Game_mall.Any(e => e.Game_number == id);
        }
    }
}
