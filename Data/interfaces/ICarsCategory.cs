using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealership_ver2.Data.Models;

namespace CarDealership_ver2.Data.interfaces
{
    public interface ICarsCategory
    {
         IEnumerable<Category> AllCategories { get; }
    }
}
