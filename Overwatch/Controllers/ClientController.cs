using Microsoft.AspNetCore.Mvc;
using Overwatch.DataAccess;
using Overwatch.DataAccess.Repository;
using Overwatch.DataAccess.Repository.IRepository;
using Overwatch.Models;

namespace Overwatch.Controllers
{
    public class ClientController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ClientController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Client> objectList = _unitOfWork.Client.GetAll();
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
            if (ModelState.IsValid)
            {
                _unitOfWork.Client.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Client is successvol gemaakt!";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0) 
            { 
                return NotFound();
            }

            var clientFromDb = _unitOfWork.Client.GetFirstOfDefault(u=>u.Id== id);

            if (clientFromDb == null) 
            {
                return NotFound();
            }

            return View(clientFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Client obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Client.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Client is successvol gewijzigd!";
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var clientFromDb = _unitOfWork.Client.GetFirstOfDefault(u=> u.Id == id);

            if (clientFromDb == null)
            {
                return NotFound();
            }

            return View(clientFromDb);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _unitOfWork.Client.GetFirstOfDefault(u => u.Id == id);

            if (obj == null) 
            { 
                return NotFound(); 
            }
            _unitOfWork.Client.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Client is successvol verwijderd!";

            return RedirectToAction("Index");
        }
    }
}
