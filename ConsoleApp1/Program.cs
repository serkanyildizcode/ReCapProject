using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAllByBrandId(1))
            {
                Console.WriteLine(car.DailyPrice);

            }

            
        }
    }
}
