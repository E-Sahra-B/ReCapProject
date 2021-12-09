using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}

            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(car.CarName + " " + car.BrandName 
            //        + " "+car.ColorName + " " +car.DairlyPrice); 
            //}

            //BrandManager bm = new BrandManager(new EfBrandDal());
            //foreach (var item in bm.GetAll())
            //{
            //    Console.WriteLine(item.BrandName);
            //}

            //ColorManager cm = new ColorManager(new EfColorDal());
            //foreach (var item in cm.GetAll())
            //{
            //    Console.WriteLine(item.ColorName);
            //}

            //UserManager userManager = new UserManager(new EfUserDal());
            //foreach (var um in userManager.GetAll())
            //{
            //    Console.WriteLine(um.LastName);
            //}
           
        }
    }
}
