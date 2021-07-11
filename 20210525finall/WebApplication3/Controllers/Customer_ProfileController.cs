using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;
using WebApplication3.Models.Data;

namespace WebApplication3.Controllers
{
    public class Customer_ProfileController : Controller
    {
        private readonly GameDbContext _context;

        public Customer_ProfileController(GameDbContext context)
        {
            _context = context;
        }

        // GET: Customer_Profile
        public async Task<IActionResult> Index()
        {
            return View(await _context.Customer_Profile.ToListAsync());
        }

        // GET: Customer_Profile/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer_Profile = await _context.Customer_Profile
                .FirstOrDefaultAsync(m => m.Customer_number == id);
            if (customer_Profile == null)
            {
                return NotFound();
            }

            return View(customer_Profile);
        }

        // GET: Customer_Profile/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customer_Profile/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Customer_number,Customer_name,Gender,Email,Account,Password,Address,Game_point")] Customer_Profile customer_Profile)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer_Profile);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer_Profile);
        }

        // GET: Customer_Profile/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer_Profile = await _context.Customer_Profile.FindAsync(id);
            if (customer_Profile == null)
            {
                return NotFound();
            }
            return View(customer_Profile);
        }

        // POST: Customer_Profile/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Customer_number,Customer_name,Gender,Email,Account,Password,Address,Game_point")] Customer_Profile customer_Profile)
        {
            if (id != customer_Profile.Customer_number)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer_Profile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Customer_ProfileExists(customer_Profile.Customer_number))
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
            return View(customer_Profile);
        }

        // GET: Customer_Profile/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer_Profile = await _context.Customer_Profile
                .FirstOrDefaultAsync(m => m.Customer_number == id);
            if (customer_Profile == null)
            {
                return NotFound();
            }

            return View(customer_Profile);
        }

        // POST: Customer_Profile/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer_Profile = await _context.Customer_Profile.FindAsync(id);
            _context.Customer_Profile.Remove(customer_Profile);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Customer_ProfileExists(int id)
        {
            return _context.Customer_Profile.Any(e => e.Customer_number == id);
        }
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(Customer_Profile Model)
        {
            return View();
        }
    }
}
