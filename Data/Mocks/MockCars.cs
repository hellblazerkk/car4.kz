﻿using car4.kz.Data.Interfaces;
using car4.kz.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car4.kz.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car 
                    {
                        name = "Tesla Model S",
                        shortDesc = "Быстрый Автомобиль",
                        longDesc = "Красивый, быстрый и очень тихий автомобиль компаний Tesla",
                        img = "/img/Model S.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/fiesta.jpg",
                        price = 11000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last(),
                    },
                    new Car
                    {
                        name = "BMW М3",
                        shortDesc = "Дерзкий и стильный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/M3.jpg",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last(),
                    },
                    new Car
                    {
                        name = "Mercedes C class",
                        shortDesc = "Уютный и большой",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/c class.jpg",
                        price = 40000,
                        isFavourite = false,
                        available = false,
                        Category = _categoryCars.AllCategories.Last(),
                    },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Бесшумный и экономный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/nissan.jpg",
                        price = 14000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First(),
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
