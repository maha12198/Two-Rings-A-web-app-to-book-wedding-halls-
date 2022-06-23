using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Final_Project.Data;
using Final_Project.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Final_Project.Controllers
{
    public class UserBookHallsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserBookHallsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UserBookHalls
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var applicationDbContext = _context.UserBookHalls.Include(u => u.Hall).Include(u => u.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: UserBookHalls/Details/5
        public async Task<IActionResult> Details(DateTime? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userBookHall = await _context.UserBookHalls
                .Include(u => u.Hall)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.RequiredDay == id);
            if (userBookHall == null)
            {
                return NotFound();
            }

            return View(userBookHall);
        }

        // GET: UserBookHalls/Create
        public IActionResult Create()
        {
            ViewData["HallId"] = new SelectList(_context.Halls, "id", "DetailsPicture");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: UserBookHalls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,HallId,RequiredDay,Phone,BookDay,approved")] UserBookHall userBookHall)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userBookHall);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HallId"] = new SelectList(_context.Halls, "id", "DetailsPicture", userBookHall.HallId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", userBookHall.UserId);
            return View(userBookHall);
        }

        // GET: UserBookHalls/Edit/5
        public async Task<IActionResult> Edit(DateTime? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userBookHall = await _context.UserBookHalls.FindAsync(id);
            if (userBookHall == null)
            {
                return NotFound();
            }
            ViewData["HallId"] = new SelectList(_context.Halls, "id", "DetailsPicture", userBookHall.HallId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", userBookHall.UserId);
            return View(userBookHall);
        }

        // POST: UserBookHalls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(DateTime id, [Bind("UserId,HallId,RequiredDay,Phone,BookDay,approved")] UserBookHall userBookHall)
        {
            if (id != userBookHall.RequiredDay)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userBookHall);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserBookHallExists(userBookHall.RequiredDay))
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
            ViewData["HallId"] = new SelectList(_context.Halls, "id", "DetailsPicture", userBookHall.HallId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", userBookHall.UserId);
            return View(userBookHall);
        }

        // GET: UserBookHalls/Delete/5
        public async Task<IActionResult> Delete(DateTime? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userBookHall = await _context.UserBookHalls
                .Include(u => u.Hall)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.RequiredDay == id);
            if (userBookHall == null)
            {
                return NotFound();
            }

            return View(userBookHall);
        }

        // POST: UserBookHalls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(DateTime id)
        {
            var userBookHall = await _context.UserBookHalls.FindAsync(id);
            _context.UserBookHalls.Remove(userBookHall);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserBookHallExists(DateTime id)
        {
            return _context.UserBookHalls.Any(e => e.RequiredDay == id);
        }
    }
}
