using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCarTest();
            GetCarsByBrand();

        }

        private static void GetCarsByBrand()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var x in carManager.GetCarsByBrandId()
            {
                Console.WriteLine(x.CarName);
            }
        }

        private static void GetCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var x in carManager.GetCarDetails()
            {
                Console.WriteLine(x.CarName + "/" + x.BrandName);
            }
        }
    }
}
