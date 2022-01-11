using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership_ver2.Data.Models{
    public class Category
    {
        public int Category_id { set; get; }
        public string CarCategory { set; get; }
        public string Comment { set; get; }
        public string GearBox { set; get; }
        public string EngineType { set; get; }
        public string EngineCapacity { set; get; }
        public string CarOdometer { set; get; }



        public List<Car> cars { set; get; }//какие товары входят в эту категорию
    }
}