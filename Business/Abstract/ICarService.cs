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
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetListByBrandId(int brandId);
        IDataResult<List<Car>> GetListByColorId(int colorId);
        IDataResult<Car> GetById(int id);
        IResult Add(Car car);
        IResult Remove(Car car);
        IResult Update(Car car);
    }
}
