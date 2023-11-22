﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id = 1, BrandId = 1, ColorId=1, DailyPrice = 2000000, ModelYear =2023, Description = "Mercedes Truck" },
                new Car { Id = 2, BrandId = 2, ColorId=3, DailyPrice = 450000, ModelYear =2005, Description = "Audi Sedan" },
                new Car { Id = 3, BrandId = 3, ColorId=2, DailyPrice = 120000, ModelYear =1993, Description = "Tofaş Şahin" },
                new Car { Id = 4, BrandId = 1, ColorId=3, DailyPrice = 1000000, ModelYear =2021, Description = "Mercedes Sedan" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c=>c.Id == id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.FirstOrDefault(c=>c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}