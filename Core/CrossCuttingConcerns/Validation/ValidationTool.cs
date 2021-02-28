using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(object type, IValidator validator)
        {
            var validationContext = new ValidationContext<object>(type);
            var result = validator.Validate(validationContext);
            if (!result.IsValid)
            {
                throw new ValidationException("Validation Error");
            }
        }
    }
}
