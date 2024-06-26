﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaWebMvc.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace SistemaWebMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Sistema Web MVC App from C# curso.";
            ViewData["Aluno"] = "Claudio de Oliveira Pereira Junior";
            ViewData["email"] = "claudio.oliveira127@outlook.com";
            ViewData["contato"] = "(21) 983949540";

            return View();
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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
