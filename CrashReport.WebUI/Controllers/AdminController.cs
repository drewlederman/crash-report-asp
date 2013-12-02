using CrashReport.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrashReport.Domain.Entities;

namespace CrashReport.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IRepository repository;

        public AdminController(IRepository repo)
        {
            repository = repo;
        }

        public ActionResult Index()
        {
            return View(repository.GetApplications());
        }

        public ActionResult ViewApp(int id = 0)
        {
            Application app = repository.GetApplications().FirstOrDefault(a => a.ApplicationId == id);

            if (app == null)
            {
                return new HttpNotFoundResult();
            }

            return View(app);
        }

        public ActionResult AddApp()
        {
            return View("EditApp", new Application());
        }

        public ActionResult EditApp(int id = 0)
        {
            Application app = repository.GetApplications().FirstOrDefault(a => a.ApplicationId == id);

            if (app == null)
            {
                return new HttpNotFoundResult();
            }

            return View(app);
        }

        [HttpPost]
        public ActionResult EditApp(Application app)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            return View(app);
        }
    }
}
