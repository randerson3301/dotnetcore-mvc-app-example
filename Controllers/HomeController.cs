using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using mvc1.Models;

namespace mvc1.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;
        private string message;

        public HomeController(IRepository repo, IConfiguration configuration)
        {
            repository = repo;
            message = configuration["MESSAGE"] ?? "ASP NET Core MVC - Docker";
        }

        public IActionResult Index(){
            ViewBag.Message = message;
            return View(repository.Produtos);
        }
    }
}
