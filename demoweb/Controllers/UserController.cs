using demoweb.Data;
using demoweb.Models;
using Microsoft.AspNetCore.Mvc;
using PagedList;

namespace demoweb.Controllers
{
    public class UserController : Controller
    {
        private readonly MyAppDbContext _context;

        public UserController(MyAppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
        
            var users = _context.Users;
            ViewBag.user = users.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(User model)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(model);
                _context.SaveChanges();
               
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id != null)
            {
                NotFound();
            }
            var user = _context.Users.Find(id);
            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(User model)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Update(model);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                NotFound();
            }
            var user = _context.Users.Find(id);
            return View(user);
        }

        [HttpPost]
        public IActionResult Delete(User model)
        {
            _context.Users.Remove(model);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            var user = _context.Users.Find(id);
            return View(user);
        }
    }
}
