using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealership_ver2.Data.interfaces;
using CarDealership_ver2.Data.Models;

namespace CarDealership_ver2.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car>
                {
                    new Car { CarBrand="Tesla Model S",
                        shortDesc="Tesla Model S P85D – ураганно-быстрый перфоманс!, 700 л.с., полный привод, 3.2с до 100км/ч",
                        longDesc="Tesla Model S P85D – ураганно-быстрый перфоманс!, 700 л.с., полный привод, 3.2с до 100км/ч, пневмоподвеска с памятью по GPS,чёрный кожаный с алькантарой салон 2 поколения + рестайлинговая консоль, превентивно заменена флэш Tegra(на гарантии),Все анатомические сидения,автопилот, парковка авто с ключа, без пробега по РБ, из США, 1 хозяин, очень ухоженный авто, Чистый карфакс и авточек – прозрачная история, результат единственного минимального повреждения авто (пер бампер)за всю историю есть на фото в США (для понимания, с какими минимальными повреждениями авто куплен в США, а не сварен из двух авто), рестайлинговый бампер, обновлённая прошивка, подключено приложение Tesla, европейская навигация и модем LTE, активирована быстрая зарядка Tesla Chademo, керамическая защита кузова и стёкол, автопарковка, отличное состояние. Обмен не интересует! Есть возможность доставки авто в Москву и установки европейских задних фонарей.",
                        Photo="C:\\Users\\ATM\\Pictures\\Saved Pictures\\6175.jpeg",
                        Year= 2019, 
                        WIN="5YJSA1H29FFP6",
                        price=45000,
                        isFavourite=true,
                        available=true,
                        Category = _categoryCars.AllCategories.First()},
                    new Car
                    {
                        CarBrand="Ford Fiesta",
                        shortDesc="Яркий и шустрый автомобиль. Родной пробег, Версия Ghia",
                        longDesc="Яркий и шустрый автомобиль. Родной пробег, Версия Ghia, оригинальный и интересный цвет кузова. Хорошая комплектация, светлый салон придает объем, все опции исправны и работают. Автомобиль на отличном ходу, ошибок нет.",
                        Photo="C:\\Users\\ATM\\Pictures\\Saved Pictures\\1058.jpeg",
                        Year= 2010,
                        WIN="WF0JXXGAJJAS4",
                        price=5990,
                        isFavourite=true,
                        available=true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        CarBrand="Chevrolet Malibu",
                        shortDesc="Отличное состояние, без проблем, очень шустрый и экономичный авто",
                        longDesc="Отличное состояние, без проблем, очень шустрый и экономичный авто, одна из самых надёжных гибридный устройств и надёжным двигателем, торг при осмотре",
                        Photo="C:\\Users\\ATM\\Pictures\\Saved Pictures\\6922.jpeg",
                        Year= 2016,
                        WIN="1G1ZE5ST7GF28",
                        price=13900,
                        isFavourite=true,
                        available=true,
                        Category = _categoryCars.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCat(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
