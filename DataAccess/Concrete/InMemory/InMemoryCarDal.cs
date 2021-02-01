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
        List<Car> _cars;
        

        public InMemoryCarDal()
        {
            _cars = new List<Car>{
                    new Car {BrandId=1,CarId=1,ColorId=1,DailyPrice=500,ModelYear=2014,Desctiption = "Opel Vectra"},
                    new Car {BrandId=1,CarId=2,ColorId=1,DailyPrice=700,ModelYear=2020,Desctiption = "Opel Corsa"},
                    new Car {BrandId=2,CarId=3,ColorId=1,DailyPrice=850,ModelYear=2019,Desctiption = "Jeep Rubicon"},
                    new Car {BrandId=2,CarId=4,ColorId=1,DailyPrice=1050,ModelYear=2016,Desctiption = "Jeep Chrokee"},
                    new Car {BrandId=3,CarId=5,ColorId=1,DailyPrice=1500,ModelYear=2021,Desctiption = "Ford Kuga"},
                };
           
        }

        

        void ICarDal.Add(Car car)
        {
            _cars.Add(car);
        }

        void ICarDal.Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        }

        List<Car> ICarDal.GetAll()
        {
            return _cars;
        }

        void ICarDal.Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Desctiption = car.Desctiption;

        }
        public List<Car> GetByCarId(int CarId)
        {
            return _cars.Where(c => c.CarId == CarId).ToList();
        }

    }
}
