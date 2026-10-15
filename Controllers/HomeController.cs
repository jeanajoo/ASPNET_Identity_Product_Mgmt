using Microsoft.AspNetCore.Mvc;
using Joo_Jeana_HW4.Models;
using System.Diagnostics;
using Joo_Jeana_HW4.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

#pragma warning restore format

namespace Joo_Jeana_HW4.Controllers
{
    public class HomeController : Controller
    {
        // The Index action is what people see when they first go to your website URL
        public IActionResult Index()
        {
            return View();
        }

        // The Privacy action (often required by default templates)
        public IActionResult Privacy()
        {
            return View();
        }

        // The Error action handles crashes and displays the ErrorViewModel 
        // We saw this in your build errors earlier!
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}