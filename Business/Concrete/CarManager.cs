using Business.Abstract;
using Core.Utilities.ResultManagement;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        public IResult Add(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
       
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetListByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetListByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public void Remove(Car car)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
