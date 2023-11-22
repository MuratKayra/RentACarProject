using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            carManager.Update
                (new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 2500000, ModelYear = 2023, Description = "Mercedes Sport" });
            Console.WriteLine(carManager.GetById(1).Description);
        }
    }
}
