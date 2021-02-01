using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsAndModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsAndModelBinding.Controllers
{
    public class CarController : Controller
    {
        [HttpGet] // called when user clicks on URL
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost] // Called when user submits form
        public IActionResult Add(IFormCollection form)
        {
            // need server side validation for all data

            Automobile car = new Automobile();
            car.Make = form["manufacturer"];
            car.VinNum = form["vinNum"];
            car.Title = form["title"];
            car.Year = form["year"];

            // Add to DB

            ViewData["Added"] = car.Make + " " + car.Title + " was added successfully with the VIN of " + car.VinNum;

            return View();
        }

        [HttpGet]
        public IActionResult AddWithBinding() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddWithBinding(Automobile car)
        {
            if (ModelState.IsValid)
            {
                ViewData["Message"] = $"{car.Make} {car.Title} was added successfully with the VIN of {car.VinNum}";
            }

            return View();
        }
    }
}
