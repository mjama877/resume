using CarDealership.Models;
using CarDealership.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarDealership.Controllers
{
    public class CarController : Controller
    {
        ICarRepository _repo = new MockCarRepository();

        // GET: Car
        public ActionResult Index()
        {
            var cars = _repo.GetAllCars();
            return View(cars);
        }
        
        public ActionResult Details(int id)
        {
            var car = _repo.GetCarById(id);
            return View(car);
        }

        public ActionResult Add()
        {
            return View(new Car());
        }
        [HttpPost]
        public ActionResult Add(Car newCar)
        {
            ViewBag.Message = "Add a car using the form below!";
            if (ModelState.IsValid)
            {
                _repo.AddCar(newCar);
                return RedirectToAction("Index");
                
            }
            else
            {
                return View("Add");


            }
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Details2(string Year, string Make, string Model)
        {
            
            Car returnedcar = _repo.GetCarByMMY(Year, Make, Model);
            if (returnedcar==null)
            {
                return RedirectToAction("Index");
            }
            return View("Details", returnedcar);
        }

        [HttpPost]
        public ActionResult LoginUser(string username, string password)
        {
            var user = _repo.LoginUser(username, password);
            ViewBag.User = user;
            if (user == null)
            {
                return View("Login");
            }
            else { 
                var cars = _repo.GetAllCars();
                return View("Index", cars);
            }
        }
    }
}