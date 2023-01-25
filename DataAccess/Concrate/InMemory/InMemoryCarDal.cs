using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car {Id = 1, BrandId =  2, ModelYear = 2022, DailyPrice = 1000, Description = "Mercedes-Benz"},
                new Car {Id = 2, BrandId =  2, ModelYear = 2023, DailyPrice = 1200, Description = "Maybec"},
                new Car {Id = 3, BrandId =  1, ModelYear = 2021, DailyPrice = 750, Description = "BMW 2 SERİSİ GRAN COUPÉ"},
                new Car {Id = 4, BrandId =  1, ModelYear = 2022, DailyPrice = 800, Description = "YENİ BMW 3 SERİSİ SEDAN"},
                new Car {Id = 5, BrandId =  3, ModelYear = 1969, DailyPrice = 2000, Description = "Mustang Elektirikli"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine(car.Description + " Added");
        }

        public void Delete(Car car)
        {
            Car CarForDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(CarForDelete);
            Console.WriteLine(CarForDelete.Description + " Deleted");
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car CarForUptate = _cars.SingleOrDefault(c => c.Id == car.Id);
            CarForUptate.Description = car.Description;
            CarForUptate.ModelYear = car.ModelYear;
            CarForUptate.DailyPrice = car.DailyPrice;
            CarForUptate.BrandId = car.BrandId;
        }
    }
}
