using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCLab23.Models;

namespace MVCLab23.Controllers
{
    public class Users1Controller : Controller
    {
        private readonly ShopContext _context;

        public Users1Controller(ShopContext context)
        {
            _context = context;
        }

        // GET: Users1
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users1.ToListAsync());
        }

        // GET: Users1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users1 = await _context.Users1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (users1 == null)
            {
                return NotFound();
            }

            return View(users1);
        }

        // GET: Users1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserName,Password,Money")] Users1 users1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(users1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(users1);
        }

        // GET: Users1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users1 = await _context.Users1.FindAsync(id);
            if (users1 == null)
            {
                return NotFound();
            }
            return View(users1);
        }

        // POST: Users1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserName,Password,Money")] Users1 users1)
        {
            if (id != users1.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(users1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Users1Exists(users1.Id))
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
            return View(users1);
        }

        // GET: Users1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users1 = await _context.Users1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (users1 == null)
            {
                return NotFound();
            }

            return View(users1);
        }

        // POST: Users1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var users1 = await _context.Users1.FindAsync(id);
            _context.Users1.Remove(users1);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Users1Exists(int id)
        {
            return _context.Users1.Any(e => e.Id == id);
        }
    }
}
