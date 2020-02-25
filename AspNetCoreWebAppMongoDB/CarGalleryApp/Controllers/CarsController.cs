using CarGalleryApp.Models;
using CarGalleryApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CarGalleryApp.Controllers
{
    public class CarsController : Controller
    {

        private readonly CarService carService;

        public CarsController(CarService carService)
        {
            this.carService = carService;
        }

        // GET: Cars
        public ActionResult Index()
        {
            return View(carService.Get());
        }

        // GET: Cars/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = carService.Get(id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);

        }

        // GET: Cars/Create
        public ActionResult Create()
        {
            return View();
        }

        
        // GET: Cars/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = carService.Get(id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        // POST: Cars/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, Car car)
        {

            // TODO: Add update logic here
            if (id != car.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                carService.Update(id, car);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        // GET: Cars/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = carService.Get(id);

            if (car == null)
            {
                return NotFound();
            }

            return View(car);

        }

        // POST: Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            try
            {
                var car = carService.Get(id);

                if (car == null)
                {
                    return NotFound();
                }

                carService.Delete(car);
                return RedirectToAction(nameof(Index));

            }
            catch 
            {

                return View();
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Car car)
        {
            if (ModelState.IsValid)
            {
                carService.Create(car);
                return RedirectToAction(nameof(Index));
            }

            return View(car);


        }
    }
}