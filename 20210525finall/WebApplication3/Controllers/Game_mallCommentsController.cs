using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;
using WebApplication3.Models.Data;
using WebApplication3.ViewModel;

namespace WebApplication3.Controllers
{
    public class Game_mallCommentsController : Controller
    {
        private readonly GameDbContext _context;

        public Game_mallCommentsController(GameDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Game_mallCommentViewModel game_mallCommentViewModel)
        {
            var comment = game_mallCommentViewModel.Comment;
            var comment_Game_number = game_mallCommentViewModel.Comment_Game_number;
            var rating = game_mallCommentViewModel.Rating;

            Game_mallComment game_mallComment = new Game_mallComment()
            {
                Comment_Game_number = comment_Game_number,
                Comments = comment,
                Rating = rating,
                PublishedDate = DateTime.Now,
            };

            _context.Game_mallComments.Add(game_mallComment);
            _context.SaveChanges();
            return RedirectToAction("Details", "Game_mallViewComments", new { id = comment_Game_number });
        }


        // GET: Game_mallComments
        public async Task<IActionResult> Index()
        {
            return View(await _context.Game_mallComments.ToListAsync());
        }

        // GET: Game_mallComments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game_mallComment = await _context.Game_mallComments
                .FirstOrDefaultAsync(m => m.Id == id);
            if (game_mallComment == null)
            {
                return NotFound();
            }

            return View(game_mallComment);
        }

        // GET: Game_mallComments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Game_mallComments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Comments,PublishedDate,Comment_Game_number,Rating,RatingSum,RatingCount")] Game_mallComment game_mallComment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(game_mallComment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(game_mallComment);
        }

        // GET: Game_mallComments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game_mallComment = await _context.Game_mallComments.FindAsync(id);
            if (game_mallComment == null)
            {
                return NotFound();
            }
            return View(game_mallComment);
        }

        // POST: Game_mallComments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Comments,PublishedDate,Comment_Game_number,Rating,RatingSum,RatingCount")] Game_mallComment game_mallComment)
        {
            if (id != game_mallComment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(game_mallComment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Game_mallCommentExists(game_mallComment.Id))
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
            return View(game_mallComment);
        }

        // GET: Game_mallComments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game_mallComment = await _context.Game_mallComments
                .FirstOrDefaultAsync(m => m.Id == id);
            if (game_mallComment == null)
            {
                return NotFound();
            }

            return View(game_mallComment);
        }

        // POST: Game_mallComments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var game_mallComment = await _context.Game_mallComments.FindAsync(id);
            _context.Game_mallComments.Remove(game_mallComment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Game_mallCommentExists(int id)
        {
            return _context.Game_mallComments.Any(e => e.Id == id);
        }
    }
}
