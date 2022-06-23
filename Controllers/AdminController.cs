using Final_Project.Areas.Identity.Pages.Account;
using Final_Project.Data;
using Final_Project.Models;
using Final_Project.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Text.Encodings.Web;

namespace Final_Project.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        public SignInManager<ApplicationUser> _signInManager;
        IEmailSender _emailSender;
        private readonly IWebHostEnvironment _webHostEnvironment;
        ApplicationDbContext context;
    

        public AdminController(ApplicationDbContext Context,
            UserManager<ApplicationUser> userManager, 
            IWebHostEnvironment webHostEnvironment,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            IEmailSender emailSender)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            context = Context;
            _webHostEnvironment = webHostEnvironment;
            _roleManager = roleManager;
            _emailSender = emailSender;
        }

       

        public  async Task< IActionResult> Index()
        {
            ViewBag.mangerCount= context.UserRoles.Where(u=>u.RoleId== "dd6a3ea7-3c4f-4bed-bdf8-5a09bcd785df").ToList().Count();
            return View();
        }

        public IActionResult ShowHalls()
        {
            return View(context.Halls.Include(h => h.Manager));
        }



        public ActionResult UpdateHall(int id)
        {
            ViewBag.Mangerid = getMangers();
            var h = context.Halls.FirstOrDefault(h => h.id == id);
            return View(h);
        }

        [HttpPost]
        public ActionResult UpdateHall(int id, string name, string location, double price, string Mangerid)
        {

            ViewBag.Mangerid = getMangers();
            var h = context.Halls.FirstOrDefault(h => h.id == id);
            if (ModelState.IsValid)
            {

                h.Name = name;
                h.Location = location;
                h.Price = price;
                h.ManagerId = Mangerid;
                try
                {
                    context.SaveChanges();
                    return RedirectToAction("ShowHalls");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                    return View(h);
                }
            }

            return View(h);
        }


        public ActionResult UpdateHallImages(int id)
        {
            var hallimages = context.hallImages.Where(i => i.HallId == id);
            ViewBag.id = id;
            return View(hallimages.Include(h => h.Hall));
        }
        [HttpPost]
        public async Task<ActionResult> UpdateHallImages(int id, IFormFileCollection file)
        {
            var hall = context.Halls.Where(h => h.id == id).FirstOrDefault();
            if (ModelState.IsValid)
            {

                string folder = "images/HallImages/";

                foreach (var item in file)
                {

                    hall.HallImages.Add(new HallImage()
                    {
                        Name = item.Name,
                        URL = await UploadImage(folder, item)
                    });
                }
                try
                {
                    context.SaveChanges();
                    return RedirectToAction("HallDetails", new { id = hall.id });
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                    return View(hall.HallImages);
                }
            }
            return View(hall.HallImages);


        }
 

        public ActionResult DeleteHallImage(int id)
        {
            var hallimage = context.hallImages.Where(h => h.id == id).FirstOrDefault();
            int hallid = hallimage.HallId;
            try
            {
                context.hallImages.Remove(hallimage);
                context.SaveChanges();
                TempData["deleted"] = hallimage.Name  + "deleted successfully " ;
                return RedirectToAction("UpdateHallImages", new { id = hallid });
            }
            catch (Exception e)
            {
                TempData["deleted"] = "can't delete this image  "+" "+e.Message;
                return RedirectToAction("UpdateHallImages", new { id = hallid });
            }

        }

        public IActionResult DeleteHall(int id)
        {
            var h = context.Halls.FirstOrDefault(ha => ha.id == id);
            var reservations = context.UserBookHalls.Where(u => u.HallId == id).ToList();
            if (reservations.Count() != 0)
            {
                foreach (var item in reservations)
                {
                    if (!item.approved)
                    {
                        TempData["deleted"] = "can't delete this Hall ,still has pending reservations ";
                        return RedirectToAction("ShowHalls");
                    }
                }
            }


            try
            {
                context.Halls.Remove(h);
                context.SaveChanges();
                TempData["deleted"] = h.Name + "  " + "deleed successfully";
                return RedirectToAction("ShowHalls");
            }
            catch (Exception e)
            {
                TempData["deleted"] = "can't delete this item" + " " + e.Message;
                return RedirectToAction("ShowHalls");
            }
        }

        public IActionResult HallDetails(int id)
        {
            var h = context.Halls.FirstOrDefault(ha => ha.id == id);
            h.HallImages =context.hallImages.Where(h => h.HallId == id).ToList();
            h.Manager = context.Users.Where(u => u.Id == h.ManagerId).FirstOrDefault();
            HallVM hallvm = new HallVM()
            {
                Id = h.id,
                Name = h.Name,
                Location = h.Location,
                Price = h.Price,
                mangerName = h.Manager.UserName,
                mangerid=h.ManagerId,
       
                
            };
            hallvm.Gallery = new List<HallImage>();
            foreach (var item in h.HallImages)
            {
                hallvm.Gallery.Add(item);
            }
            return View(hallvm);


        }
        public IActionResult CreateHall()
        {
            ViewBag.Mangerid = getMangers();
            return View(new HallVM());
        }
        [HttpPost]

        public async Task<IActionResult> CreateHall(HallVM hall)
        {

            ViewBag.Mangerid = getMangers();

            if (ModelState.IsValid)
            {
                

                Hall newhall = new Hall()
                {

                    Name = hall.Name,
                    Location = hall.Location,
                    Price = hall.Price,
                    ManagerId = hall.mangerid,
               

                };

                if (hall.HallPhotos != null)
                {
                    string folder = "images/HallImages/";

                    newhall.HallImages = new List<HallImage>();


                    foreach (var file in hall.HallPhotos)
                    {
                        newhall.HallImages.Add(new HallImage()
                        {
                            Name = file.Name,
                            URL = await UploadImage(folder, file)
                        });
                    }
                }
                try
                {
                    context.Halls.Add(newhall);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                    return View(hall);
                }
            }
            return View(hall);

        }

        public ActionResult CreatePackage()
        {
            var halls = context.Halls;
            var users = halls.OfType<Hall>();
            ViewBag.HallId=new SelectList(users, "id", "Name");
            return View(new PackageVM());
        }
        [HttpPost]
        public ActionResult CreatePackage(PackageVM package)
        {
            HallPackages hallPackage = new HallPackages();
            if (ModelState.IsValid)
            {


                hallPackage.Name = package.Name;
                hallPackage.NumberOfPersons = package.NumberOfPersons;
                hallPackage.cake = package.cake;
                hallPackage.food = package.food;
                hallPackage.HallId = package.HallId;
                hallPackage.price = package.price;


                try
                {
                    context.HallPackages.Add(hallPackage);
                    context.SaveChanges();
                    return RedirectToAction("Showpackages", new { id = hallPackage.HallId });
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                    return View(hallPackage);
                }
            }
            return View(hallPackage);

        }

        public ActionResult Showpackages(int id)
        {
            var backages = context.HallPackages.Where(h => h.HallId == id).Include(h=>h.Hall);
            return View(backages);
        }
      
        public ActionResult UpdatePackage(int id)
        {
            var package = context.HallPackages.Where(h => h.Id == id).FirstOrDefault();
            PackageVM mypackage = new PackageVM()
            {
                id=package.Id,
                Name = package.Name,
                NumberOfPersons = package.NumberOfPersons,
                cake = package.cake,
                food = package.food,
                HallId = package.HallId,
                price=package.price
            };
            var halls = context.Halls;
            var users = halls.OfType<Hall>();
            ViewBag.HallId = new SelectList(users, "id", "Name");

            return View(mypackage);
        }

        [HttpPost]
        public ActionResult UpdatePackage(int id,PackageVM mypackage)
        {
            var halls = context.Halls;
            var users = halls.OfType<Hall>();
            ViewBag.HallId = new SelectList(users, "id", "Name");

            var package = context.HallPackages.Where(h => h.Id ==id).FirstOrDefault();
            if (ModelState.IsValid)
            {
                package.Name = mypackage.Name;
                package.NumberOfPersons = mypackage.NumberOfPersons;
                package.cake = mypackage.cake;
                package.food = mypackage.food;
                package.HallId = mypackage.HallId;
                package.price = mypackage.price;
                try
                {
                    context.SaveChanges();
                    return RedirectToAction("Showpackages", new { id = package.HallId });
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                    return View(mypackage);
                }
            }

            return View(mypackage);
        }

        public ActionResult DeletePackage(int id)
        {
            var hallpackage = context.HallPackages.Where(h => h.Id == id).FirstOrDefault();
            int hallid = hallpackage.HallId;
            try
            {
                context.HallPackages.Remove(hallpackage);
                context.SaveChanges();
                TempData["deleted"] = hallpackage.Name +" "+ "deleted successfully ";
                return RedirectToAction("Showpackages", new { id = hallid });
            }
            catch (Exception e)
            {
                TempData["deleted"] = "can't delete this image  " + " " + e.Message;
                return RedirectToAction("Showpackages", new { id = hallid });
            }
        }

        private async Task<string> UploadImage(string folderPath, IFormFile file)
        {

            folderPath += Guid.NewGuid().ToString() + "_" + file.FileName;

            string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folderPath);

            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));

            return "/" + folderPath;
        }

        private SelectList getMangers()
        {
            var usersWithPermission = _userManager.GetUsersInRoleAsync("Manger").Result;
            var users = usersWithPermission.OfType<ApplicationUser>();

            return new SelectList(users, "Id", "UserName");
        }

        // User Actions 

        public IActionResult ShowUsers()
        {
            var users = context.Users.ToList();

            return View(users);
        }
        public ActionResult UserDetails(string id)
        {
            var user = context.Users.Where(u => u.Id == id).FirstOrDefault();
            return View(user);

        }

        public ActionResult UpdateUser(string id)
        {
            var user = context.Users.Where(u => u.Id == id).FirstOrDefault();
            RegisterModel.InputModel input = new RegisterModel.InputModel()
            {
                FirstName = user.First_Name,
                LastName=user.Last_Name,
                Email=user.Email,
                UserName=user.UserName,
                PhoneNumber=user.PhoneNumber,
            };

            return View(input);
        }
        [HttpPost]
        public ActionResult UpdateUser(string id, string UserName, string FirstName, string LastName, string Email, string PhoneNumber)
        {
            var u = context.Users.Where(u => u.Id == id).FirstOrDefault();
            if (ModelState.IsValid)
            {
                u.UserName = UserName;
                u.NormalizedUserName = UserName;
                u.First_Name = FirstName;
                u.Last_Name = LastName;
                u.Email = Email;
                u.NormalizedEmail = Email;
                u.PhoneNumber = PhoneNumber;
                try
                {
                    context.SaveChanges();
                    TempData["Updated"] = UserName;
                    return RedirectToAction("ShowUsers");
                }
                catch (Exception e)
                {
                    TempData["Updated"] = "can't Updated this item" + " " + e.Message;
                    return View(u);
                }

            }
            return View(u);
        }
        public async Task<ActionResult> DeleteUserAsync(string id)
        {
            var user = context.Users.FirstOrDefault(u => u.Id == id);
            var Hall = context.Halls.Where(h => h.ManagerId == user.Id).ToList();

            var roles = await _userManager.GetRolesAsync(user);
            var FromBookTable = context.UserBookHalls.Where(b => b.UserId == user.Id).ToList();

            if (Hall.Count != 0)
            {
                foreach (var item in Hall)
                {
                    var reservations = context.UserBookHalls.Where(u => u.HallId == item.id);
                    foreach (var item2 in reservations)
                    {
                        if (!item2.approved)
                        {
                            TempData["deleted"] = "can't delete this user as his hall still has pending reservations ";
                            return RedirectToAction("ShowUsers");
                        }

                    }
                    context.Halls.Remove(item);
                }
            }
            if (roles.Count != 0)
            {
                foreach (var item in roles)
                {
                    await _userManager.RemoveFromRoleAsync(user, item);

                }

            }

            if (FromBookTable.Count != 0)
            {
                context.UserBookHalls.RemoveRange(FromBookTable);
            }
            try
            {

                context.Users.Remove(user);
                context.SaveChanges();
                TempData["deleted"] = user.UserName;
                return RedirectToAction("ShowUsers");
            }
            catch (Exception e)
            {
                TempData["deleted"] = "can't delete this item" + " " + e.Message;
                return RedirectToAction("ShowUsers");
            }
        }

        public ActionResult UpdateRole()
        {
            ViewBag.Name = new SelectList(context.Roles.ToList(), "Name", "Name");
            ViewBag.UserName = new SelectList(context.Users.ToList(), "UserName", "UserName");

            return View();
        }
        [HttpPost]
        public async Task<ActionResult> UpdateRole(string Name,string UserName)
        {
            var user = context.Users.Where(i => i.UserName == UserName).FirstOrDefault();
            var roles = await _userManager.GetRolesAsync(user);
            if (roles.Count != 0)
            {
                if (roles[0] != Name)
                {
                    var s = await _userManager.RemoveFromRoleAsync(user, roles[0]);
                    var w = await _userManager.AddToRoleAsync(user, Name);
                }

            }
            else
            {
                var w = await _userManager.AddToRoleAsync(user, Name);
            }
            context.SaveChanges();

            return RedirectToAction("Index", "Admin");
        }

        public async Task<ActionResult> CreateUser()
        {
            return View(new InputModel());
        }

        [HttpPost]
        public async Task<ActionResult> CreateUser(InputModel Input)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { First_Name = Input.FirstName, Last_Name = Input.LastName, PhoneNumber = Input.PhoneNumber, UserName = Input.UserName, Email = Input.Email };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    if (Input.role != null)
                    {
                        if (!await _roleManager.RoleExistsAsync(Input.role))
                        {
                            await _roleManager.CreateAsync(new IdentityRole(Input.role));
                        }

                        await _userManager.AddToRoleAsync(user, Input.role);
                    }

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: "Confirm",
                        values: new { area = "Identity", userId = user.Id, code = code },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(user.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");


                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return View("RegisterConfirmation");
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("Index", "Home");
                    }

                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return View(Input);
        }


    }

}
