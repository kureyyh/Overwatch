using Microsoft.AspNetCore.Mvc;
using Overwatch.Data;
using Overwatch.Models;

namespace Overwatch.Controllers
{
    public class ClientController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ClientController(ApplicationDbContext db)
        {
            _db = db;   
        }

        public IActionResult Index()
        {
            IEnumerable<Client> objectList = _db.Clients;
            return View(objectList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Client obj)
        {
            _db.Clients.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
