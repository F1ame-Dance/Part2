using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Throw() => throw new ApplicationException("Test error!");

        public IActionResult SecondAction(string id) => Content($"Action with value id:{id}");

        public IActionResult Error404() => View();

        public IActionResult ErrorStatus(string code) => code switch
        {
            "404" => RedirectToAction(nameof(Error404)),
            _ => Content($"Error code: {code}")
        };
    }
}
