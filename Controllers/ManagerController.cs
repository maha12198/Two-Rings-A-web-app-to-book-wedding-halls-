using Final_Project.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;

namespace Final_Project.Controllers
{
    [Authorize(Roles = "Manger")]
    public class ManagerController : Controller
    {
        ApplicationDbContext context;
        public ManagerController(ApplicationDbContext Context)
        {
            context = Context;
        }
        public IActionResult Index()
        {
            var name = User.FindFirstValue(ClaimTypes.Name);
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var halls = context.Halls.Where(h => h.ManagerId == userid).ToList();
          
            return View(halls);
        }

        public IActionResult Delete(int HallID, DateTime DateTime)
        {
            var halls = context.UserBookHalls.Find(DateTime, HallID);
            context.UserBookHalls.Remove(halls);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ApprovedReservation()
        {
            var name = User.FindFirstValue(ClaimTypes.Name);
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var halls = context.Halls.Where(h => h.ManagerId == userid).ToList();

            return View(halls);
        }

        public ActionResult Approve(int HallID, DateTime DateTime)
        {
           var halls= context.UserBookHalls.Find(DateTime, HallID);
           
            halls.approved = true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        

    }
}
