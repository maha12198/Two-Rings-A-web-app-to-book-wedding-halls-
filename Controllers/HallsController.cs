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
using Final_Project.Models.ViewModels;

namespace Final_Project.Controllers
{
    public class HallsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HallsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Halls
        public IActionResult getReservation()
        {
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var applicationDbContext = _context.UserBookHalls.Include(h => h.UserId==userid);
            return View( applicationDbContext);
        }
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Halls.Include(h => h.HallImages);
            return View(await applicationDbContext.ToListAsync());
        }

        public IActionResult Filter(string SearchString, int min, int max)
        {
            if (SearchString != null)
            {

                var applicationDbContext = _context.Halls.Where(h => h.Name.Contains(SearchString) || h.Location.Contains(SearchString)).Include(h=>h.HallImages).ToList();
                return View("index", applicationDbContext);
            }
            if (min >= 0 && max >= 0)
            {
                var applicationDbContext = _context.Halls.Where(h => h.Price >= min && h.Price <= max).Include(h => h.HallImages).ToList();
                return View("index", applicationDbContext);
            }
            return View();
        }
    

        // GET: Halls/Details/5
        public IActionResult Details(int id)
        {
            var h = _context.Halls.FirstOrDefault(ha => ha.id == id);
            h.HallImages = _context.hallImages.Where(h => h.HallId == id).ToList();
            h.Manager = _context.Users.Where(u => u.Id == h.ManagerId).FirstOrDefault();
            HallVM hallvm = new HallVM()
            {
                Id = h.id,
                Name = h.Name,
                Location = h.Location,
                Price = h.Price,
                mangerName = h.Manager.UserName,
                mangerid = h.ManagerId,
                phone= h.Manager.PhoneNumber

            };
            hallvm.Gallery = new List<HallImage>();
            foreach (var item in h.HallImages)
            {
                hallvm.Gallery.Add(item);
            }
            var backages = _context.HallPackages.Where(h => h.HallId == id).Include(h => h.Hall);
            ViewBag.backages = backages;
            return View(hallvm);


        }

        //user details
        public ActionResult UserDetails(string id)
        {
            var user = _context.Users.Where(u => u.Id == id).FirstOrDefault();
            return View(user);

        }

        [Authorize]
        public IActionResult Booking(int id)
        {
            ViewData["userId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["hallID"] = new SelectList(_context.Halls, "id", "id");
            ViewData["PakedgeID"] = new SelectList(_context.HallPackages, "id", "id");

            var userName = User.FindFirstValue(ClaimTypes.Name); // will give the user's userName
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);// will give the user's userId
            ViewBag.msg = userId;
            ViewBag.userName = userName;

            var url = Url.ActionContext.RouteData.Values["id"];
            ViewBag.hallIdUrl = url;

            var urlPakdge = Url.ActionContext.RouteData.Values["id"];
            ViewBag.urlPakdge = urlPakdge;

            var h = _context.Halls.FirstOrDefault(ha => ha.id == id);
            ViewBag.NameHall = h.Name;

            var backages = _context.HallPackages.Where(h => h.HallId == id).Include(h => h.Hall);

            ViewBag.backages = backages;

           
            ViewBag.currentDate = DateTime.Now.ToString("dd-MM-yyyy");




            //var H = _context.Halls.FirstOrDefault(ha => ha.id == id);
            //H.HallPackages = _context.HallPackages.Where(h => h.Id == id).ToList();
            //h.Manager = _context.Users.Where(u => u.Id == h.ManagerId).FirstOrDefault();

            //var backageId = _context.HallPackages.Where(h => h.HallId == id).Include(h => h.Hall);
            //ViewBag.backageId = H.HallPackages;

            //ViewBag.Mangerid = getMangers(ViewBag.hallIdUrl);
            var hallPakedge = _context.HallPackages.Where(h => h.HallId == id).Include(h => h.Hall); 
          
                var packages = hallPakedge.OfType<HallPackages>();

                ViewBag.HallPakedgID = new SelectList(packages, "Id", "Name");
        
           
            return View();
        }
        private SelectList getMangers(int id)
        {
            var backagesId = _context.HallPackages.Where(h => h.HallId == id).Include(h => h.Hall);
            var users = backagesId.OfType<ApplicationUser>();

            return new SelectList(users, "Id", "Name");
        }
        public ActionResult Showpackages(int id)
        {
            var backages = _context.HallPackages.Where(h => h.HallId == id).Include(h => h.Hall);
            return View(backages);
        }

        // POST: Halls/Booking
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Booking([Bind("UserId,HallId,PackageId,RequiredDay,Phone,BookDay")] UserBookHall userBook)
        {
            if (ModelState.IsValid)
            {
               
                try
                {
                    
                    _context.Add(userBook);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception e)
                {
                    TempData["Error"] = "This date has already been booked!" + " " ;
                    return RedirectToAction("Booking");
                }
            }

            //else
            //{
            //    var msg = "This Date is Completed";
            //    ViewBag.error = msg;
            //}


            // For ASP.NET Core <= 3.1

            //ViewData["hallID"] = _context.Halls.Include(h => h.id);

            return View(userBook);
        }


        // GET: Halls/Create
        public IActionResult Create()
        {
            ViewData["ManagerId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Halls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ManagerId,id,Name,Location,Price,DetailsPicture")] Hall hall)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hall);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ManagerId"] = new SelectList(_context.Users, "Id", "Id", hall.ManagerId);
            return View(hall);
        }

        // GET: Halls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hall = await _context.Halls.FindAsync(id);
            if (hall == null)
            {
                return NotFound();
            }
            ViewData["ManagerId"] = new SelectList(_context.Users, "Id", "Id", hall.ManagerId);
            return View(hall);
        }

        // POST: Halls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ManagerId,id,Name,Location,Price,DetailsPicture")] Hall hall)
        {
            if (id != hall.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hall);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HallExists(hall.id))
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
            ViewData["ManagerId"] = new SelectList(_context.Users, "Id", "Id", hall.ManagerId);
            return View(hall);
        }

        // GET: Halls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hall = await _context.Halls
                .Include(h => h.Manager)
                .FirstOrDefaultAsync(m => m.id == id);
            if (hall == null)
            {
                return NotFound();
            }

            return View(hall);
        }

        // POST: Halls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hall = await _context.Halls.FindAsync(id);
            _context.Halls.Remove(hall);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HallExists(int id)
        {
            return _context.Halls.Any(e => e.id == id);
        }
    }
}
