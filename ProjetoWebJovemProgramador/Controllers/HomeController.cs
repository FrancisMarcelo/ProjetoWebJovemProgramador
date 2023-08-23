using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProjetoWebJovemProgramador.Models;
using System.Diagnostics;
using System.Text.Json;

namespace ProjetoWebJovemProgramador.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

       

       
    }


}