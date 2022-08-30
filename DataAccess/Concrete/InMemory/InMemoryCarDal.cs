using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    
    public class InMemoryCarDal : ICarDal
       
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
            new Car{Id=1,BrandId=1,ColorId=1, DailyPrice=125,ModelYear=2020,Description="Porche"},
            new Car{Id=2,BrandId=1,ColorId=2, DailyPrice=100,ModelYear=2021,Description="Porche"},
            new Car{Id=3,BrandId=2,ColorId=1, DailyPrice=150,ModelYear=2022,Description="Mercedes"},
            new Car{Id=4,BrandId=3,ColorId=3, DailyPrice=175,ModelYear=2022,Description="BMW"},

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car cartoDelete = _cars.SingleOrDefault(c=>c.BrandId==car.BrandId);
            _cars.Remove(cartoDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=>c.BrandId == car.BrandId);
            carToUpdate.BrandId=car.BrandId;
            carToUpdate.ColorId=car.ColorId;
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.ModelYear=car.ModelYear;
            carToUpdate.Description=car.Description;

        }
    }
}
