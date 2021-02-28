
using Business.Abstract;
using Business.Constant;
using Business.ValidationRules;
using Core.Aspects.Autofac;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.ResultManagement;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarManager(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [ValidationAspect(typeof(CarValidator),Priority =1)]
        public IResult Add(Car car)
        {
          
            _carRepository.Add(car);

            return new SuccessResult()
            {
                Message = Messages.CarAdded
            };


        }

        public IDataResult<List<Car>> GetAll()
        {
            var data = _carRepository.GetList();
            return new SuccessDataResult<List<Car>>(data, Messages.GetAllCar);

        }

        public IDataResult<Car> GetById(int id)
        {
            var data = _carRepository.Get(p => p.Id == id);
            return new SuccessDataResult<Car>(data);
        }

        public IDataResult<List<Car>> GetListByBrandId(int brandId)
        {
            var data = _carRepository.GetList(p => p.BrandId == brandId);
            return new SuccessDataResult<List<Car>>(data);
        }

        public IDataResult<List<Car>> GetListByColorId(int colorId)
        {
            var data = _carRepository.GetList(p => p.ColorId == colorId);
            return new SuccessDataResult<List<Car>>(data);
        }

        public IResult Remove(Car car)
        {
            _carRepository.Delete(car);
            return new SuccessResult()
            {
                Message = Messages.CarDeleted
            };
        }

        public IResult Update(Car car)
        {
            _carRepository.Update(car);
            return new SuccessResult()
            {
                Message = Messages.CarUpdated
            };
        }
    }
}
