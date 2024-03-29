﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeatherClockApp;
using WeatherClockApp.Models;

namespace WeatherClock.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var repository = new WeatherRepository();
            ViewBag.Result = repository.GetHourlyWeather();
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
