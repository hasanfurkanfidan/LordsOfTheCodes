using Core.Utilities.ResultManagement;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        //Result Management
        //n-layered
        List<Car> GetAll();
        List<Car> GetListByBrandId(int brandId);
        List<Car> GetListByColorId(int colorId);
        Car GetById(int id);        
        IResult Add(Car car);
        void Remove(Car car);
        void Update(Car car);
    }
}
