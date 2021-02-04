using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> cars;
        public InMemoryCarDal()
        {
            cars = new List<Car>
          {
             new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2007,DailyPrice=100,Description="OTOMATİK LPGLİ 1.6  CİVİC"},
             new Car{Id=2,BrandId=2,ColorId=2,ModelYear=2020,DailyPrice=250,Description="OTOMATİK BENZİNLİ 2.0 CRV 4 *4 "},
             new Car{Id=3,BrandId=3,ColorId=3,ModelYear=1995,DailyPrice=75,Description="MANUEL   DİZEL 1.0  İ20"},
             new Car{Id=4,BrandId=4,ColorId=4,ModelYear=2021,DailyPrice=350,Description=" OTOMATİK ELEKTİRİKLİ  TESLA"},
             new Car{Id=5,BrandId=2,ColorId=2,ModelYear=1990,DailyPrice=50,Description="OTOMATİK ELEKTİRİKLİ BMW "},
          };

        }



        public void Add(Car car)
        {
            cars.Add(car);
            
        }

        public void Delete(Car car)
        {
            Car deleteToCar = cars.SingleOrDefault(p => p.Id == car.Id);
            cars.Remove(deleteToCar);
        }

        public List<Car> GetAll()
        {
            return cars;
        }

        public Car GetById(int id)
        {
            Car comingWithId = cars.SingleOrDefault(p => p.Id == id);
            return comingWithId;
           
        }

        public void Update(Car car)
        {
            var toBeUpdatedCar = cars.SingleOrDefault(p => p.Id == car.Id);
            toBeUpdatedCar.ColorId = car.ColorId;
            toBeUpdatedCar.BrandId = car.BrandId;
            toBeUpdatedCar.ModelYear = car.ModelYear;
            toBeUpdatedCar.DailyPrice = car.DailyPrice;
            toBeUpdatedCar.Description = car.Description;

    }
    }
}
