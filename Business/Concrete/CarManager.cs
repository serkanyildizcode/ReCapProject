using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {

        //injection
        ICarDal _carDal;
        private EfBrandDal efBrandDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public CarManager(EfBrandDal efBrandDal)
        {
            this.efBrandDal = efBrandDal;
        }

        public List<Car> GetAll()
        {

         return _carDal.GetAll();

        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetAllByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);
        }
    }
}
