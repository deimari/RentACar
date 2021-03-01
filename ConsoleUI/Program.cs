using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Car car = new Car
            {
                Id = 2,
                Name = "Serce",
                BrandId = 1,
                ColorId = 1,
                DailyPrice = 100,
                ModelYear = 2013,
                Description = "asdasdasdasd"
            };
            Brand brand = new Brand { BrandId = 1, BrandName = "BMW" };
            Color color = new Color { ColorId = 1, ColorName = "Black" };
            carManager.Add(car);
            brandManager.Add(brand);
            colorManager.Add(color);
            Console.WriteLine("================");
            foreach (var item in carManager.GetCarDetails())
            {
                Console.WriteLine("{0} / {1} / {2} / {3} / {4}", item.CarId, item.CarName, item.BrandName, item.ModelYear, item.ColorName);
            }
        }
    }
}
