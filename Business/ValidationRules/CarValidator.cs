using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.ColorId).GreaterThan(0);
            RuleFor(p => p.BrandId).GreaterThan(0);
            RuleFor(p => p.Description).NotEmpty();
            RuleFor(p => p.BrandId).GreaterThanOrEqualTo(1);
        }
    }
}
