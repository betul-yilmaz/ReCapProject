using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrate.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{ Id = 1, BrandId = 1, ColorId = 2, DailyPrice = "500", Description = "this car is cool", ModelYear = "2021" },
                new Car{ Id = 1, BrandId = 1, ColorId = 2, DailyPrice = "150", Description = "this car is cool", ModelYear = "2021" }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p=>p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        

        //public List<Car> GetById(int Id)
        //{
        //    return _cars.Where(p => p.Id == Id).ToList();
        //}
         
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p=> p.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            
        }
    }

     
    }

