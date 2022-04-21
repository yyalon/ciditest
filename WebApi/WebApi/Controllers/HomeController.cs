using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApi.Controllers
{
    [Route("/home")]
    public class HomeController : Controller
    {
        // GET: HomeController
        [HttpGet("index")]
        public IActionResult Index()
        {
            return Json(new { data = DateTime.Now });
        }

    }
}
