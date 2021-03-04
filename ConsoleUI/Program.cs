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
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Car car = new Car
            {
                Id = 2,
                Name = "S",
                BrandId = 1,
                ColorId = 1,
                DailyPrice = 100,
                ModelYear = 2013,
                Description = "asdasdasdasd"
            };
            Brand brand = new Brand { BrandId = 1, BrandName = "BMW" };
            Color color = new Color { ColorId = 1, ColorName = "Black" };
            Customer customer = new Customer { UserId = 1, CompanyName = "ASDASD" };
            carManager.Add(car);
            customerManager.Add(customer);
            Console.WriteLine("================");
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine("{0} / {1} / {2} / {3} / {4}", item.CarId, item.CarName, item.BrandName, item.ModelYear, item.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
