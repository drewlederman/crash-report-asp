using CrashReport.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

    }
}
