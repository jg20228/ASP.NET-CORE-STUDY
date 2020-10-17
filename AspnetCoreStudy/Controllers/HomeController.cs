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

        //http://www.example.com/Home/Index
        public IActionResult Index()
        {
            var firstUser = new User
            {
                id = 1,
                name = "홍길동"
            };

            // # 1번째 방식 View(model)
            //return View(firstUser);

            // # 2번째 방식 ViewBag
            //ViewBag.User = firstUser;
            //return View();

            // # 3번째 방식 ViewData
            //객체를 넘기지 못함
            ViewData["UserId"] = firstUser.id;
            ViewData["UserName"] = firstUser.name;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
