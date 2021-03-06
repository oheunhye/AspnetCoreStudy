using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspnetCoreStudy.Models;

namespace AspnetCoreStudy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var hongUser = new User();
            //hongUser.No = 1;
            //hongUser.Name = "홍길동";

            ////#1번 방식 View(model);
            ////return View(hongUser);

            ////#2반 방식 ViewBag
            ////ViewBag.User = hongUser;

            ////#3번 방식 ViewData
            //ViewData["UserNo"] = hongUser.No;
            //ViewData["UserName"] = hongUser.Name;
            return View();
        }

        public IActionResult LoginSuccess()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
