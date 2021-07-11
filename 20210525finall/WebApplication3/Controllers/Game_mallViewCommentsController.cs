using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Access;
using WebApplication3.Models;
using WebApplication3.Models.Data;
using WebApplication3.ViewModel;

namespace WebApplication3.Controllers
{
    public class Game_mallViewCommentsController : Controller
    {
        private readonly GameDbContext _context;


        public Game_mallViewCommentsController(GameDbContext context)
        {
            _context = context;
        }

        // GET: Game_mallViewComments
        public async Task<IActionResult> Index()
        {
            return View(await _context.Game_mall.ToListAsync());
        }

        // GET: Game_mallViewComments/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            Game_mall game_mall = _context.Game_mall.Find(id);
            Game_mallCommentViewModel game_mallCommentViewModel = new Game_mallCommentViewModel();

            if (game_mall == null)
            {
                return NotFound();
            }
            game_mallCommentViewModel.Comment_Game_number = id.Value;
            game_mallCommentViewModel.Game_name = game_mall.Game_name;
            var Comments = _context.Game_mallComments.Where(d => d.Comment_Game_number.Equals(id.Value)).ToList();
            game_mallCommentViewModel.ListOfComments = Comments;

            var ratings = _context.Game_mallComments.Where(d => d.Comment_Game_number.Equals(id.Value)).ToList();
            if (ratings.Count() > 0)
            {
                var ratingSum = ratings.Sum(d => d.Rating);
                ViewBag.RatingSum = ratingSum;
                var ratingCount = ratings.Count();
                ViewBag.RatingCount = ratingCount;
            }

            else
            {
                ViewBag.RatingSum = 0;
                ViewBag.RatingCount = 0;
            }

            return View(game_mallCommentViewModel);
        }

        // GET: Game_mallViewComments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Game_mallViewComments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Game_number,Game_name,Game_category,Unit_price,Listing_date")] Game_mall game_mall)
        {
            if (ModelState.IsValid)
            {
                _context.Add(game_mall);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(game_mall);
        }

        // GET: Game_mallViewComments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
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

        // POST: Game_mallViewComments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Game_number,Game_name,Game_category,Unit_price,Listing_date")] Game_mall game_mall)
        {
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

        // GET: Game_mallViewComments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
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

        // POST: Game_mallViewComments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var game_mall = await _context.Game_mall.FindAsync(id);
            _context.Game_mall.Remove(game_mall);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Game_mallExists(int id)
        {
            return _context.Game_mall.Any(e => e.Game_number == id);
        }
    }
}
