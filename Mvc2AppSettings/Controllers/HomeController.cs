using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Mvc2AppSettings.Models;

namespace Mvc2AppSettings.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private SampleSettings settings;

        public HomeController(ILogger<HomeController> logger, IOptions<SampleSettings> settingsOptions)
        {
            _logger = logger;
            this.settings = settingsOptions.Value;
        }

        public IActionResult Index()
        {
            var s = settings.RepeatTimes;
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
