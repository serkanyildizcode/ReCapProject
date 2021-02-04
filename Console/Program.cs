
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.

            CarManager mycarObjects = new CarManager(new InMemoryCarDal());
            foreach (var car in mycarObjects.GetAll())
            {
                

            }




        }
}
}
