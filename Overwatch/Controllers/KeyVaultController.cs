using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Overwatch.Secrets;

namespace Overwatch.Controllers
{
    public class KeyVaultController : Controller
    {


        private readonly IKeyVaultManager _secretManager;

        public KeyVaultController(IKeyVaultManager secretManager)
        {
            _secretManager = secretManager;
        }

        // GET: KeyVaultController
        public ActionResult Index()
        {
            return View();
        }

        // GET: KeyVaultController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: KeyVaultController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KeyVaultController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KeyVaultController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KeyVaultController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KeyVaultController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KeyVaultController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
