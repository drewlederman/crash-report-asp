using CrashReport.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrashReport.WebUI.Controllers
{
    public class ReportsController : Controller
    {
        private IReportRepository repository;

        public ReportsController(IReportRepository repo)
        {
            repository = repo;
        }

        public ActionResult Index()
        {
            return View(repository.GetReports());
        }
    }
}
