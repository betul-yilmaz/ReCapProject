using Business.Abstract;
using DataAccess.Abstract;
//using DataAccess.Concrate.InMemory;
using Entities.Concrate; 
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        
        public List<Car> GetAll()
        {
            //İş kodları
            return _carDal.GetAll();
        }
    }
}
