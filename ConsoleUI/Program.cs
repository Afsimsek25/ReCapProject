using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
               Console.WriteLine("Car Id : "+car.CarId +"  Brand Id : " + car.BrandId +"  Günlük Kira : " + car.DailyPrice + "  Yılı : " + car.ModelYear + "  Marka : " +car.Desctiption );

               Console.WriteLine("{0} --- {1} --- {2} --- {3} --- {4} --- {5}", car.BrandId,car.CarId,car.ColorId,car.DailyPrice,car.Desctiption,car.ModelYear );
            }
            
        }
    }
}          