using CarDealership_ver2.Data.interfaces;
using CarDealership_ver2.Data.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership_ver2.Controllers
{
    public class HomeController:Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;
        public HomeController(IAllCars iAllCars, ICarsCategory iCarsCategory) {
            _allCars= iAllCars;
            _allCategories = iCarsCategory; 
        }
        public ViewResult List() {
            ViewBag.Title = "CarList";
            HomeListViewModel obj = new HomeListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currCategory = "Автомобили";
            return View(obj);
        }
    }
}
