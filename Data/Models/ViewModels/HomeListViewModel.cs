using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership_ver2.Data.Models.ViewModels
{
    public class HomeListViewModel
    {
        public IEnumerable<Car> allCars { get; set;}
        public string currCategory { get; set; }
    }
}
