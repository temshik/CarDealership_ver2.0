using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealership_ver2.Data.interfaces;
using CarDealership_ver2.Data.Models;

namespace CarDealership_ver2.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories {
            get {
                return new List<Category> {
                    new Category {CarCategory = "Электроавтомобиль",Comment="Современный взгляд на транспорт" },
                    new Category {CarCategory = "Автомобиль с ДВС",Comment="Классический автомобиль каким он был и задуман изначально" } 
                };            
            }
        }
    }
}
