using System;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;

namespace MyCompany.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageIndex"));
        }

        public IActionResult Target(Guid id)
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageTarget"));
        }

        public IActionResult InputData(Guid id)
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageInputData"));
        }

        public IActionResult PlanJob(Guid id)
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PagePlanJob"));
        }

        public IActionResult Result(Guid id)
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageResult"));
        }

        public IActionResult Aprobe(Guid id)
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageAprobe"));
        }
    }
}