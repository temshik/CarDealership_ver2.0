using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership_ver2.Data.Models
{
    public class Car
    {
        public int Car_id { set; get; }
        public string CarBrand { set; get; }
        public string shortDesc { set; get; }
        public string longDesc { set; get; }
        public string Photo { set; get; }
        public int Year { set; get; }
        public string WIN { set; get; }
        public ushort price { set; get; }
        public bool isFavourite { set; get; }//товар отображается на главной страничке 
        public bool available { set; get; }//товар на складе и сколько единиц данного товара
        public int categoryID { set; get; }
        public virtual Category Category { set; get; }
    }
}
