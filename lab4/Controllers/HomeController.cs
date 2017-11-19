using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lab4.Models;
using lab4.Data;
using lab4.ViewModels;

namespace lab4.Controllers
{
    public class HomeController : Controller
    {
        private CarsContext _db;
        public HomeController(CarsContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var additionalServices = _db.AdditionalServices.Take(5).ToList();
            var carsRental = _db.CarsRental.Take(5).ToList();
            var customers = _db.Customers.Take(5).ToList();



            HomeViewModel homeViewModel = new HomeViewModel { AdditionalServices = additionalServices, CarsRental = carsRental, Customers = customers };

            return View(homeViewModel);
        }

        public IActionResult About()
        {

            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
    }
}
