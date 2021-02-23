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
            _cars = new List<Car> {
                new Car{Id=1,BrandId=1,ColorId=23,DailyPrice=250,ModelYear="2005",Description="birinci araç"},
                new Car{Id=2,BrandId=1,ColorId=5,DailyPrice=350,ModelYear="2009",Description="ikinci araç"},
                new Car{Id=3,BrandId=2,ColorId=2,DailyPrice=500,ModelYear="2020",Description="üçüncü araç"},
                new Car{Id=4,BrandId=2,ColorId=3,DailyPrice=750,ModelYear="2020",Description="dördüncü araç"},
                new Car{Id=5,BrandId=3,ColorId=7,DailyPrice=800,ModelYear="2020",Description="beşinci araç"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p=>p.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllById(int Id)
        {
            return _cars.Where(p => p.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate= _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
