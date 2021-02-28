using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interception;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac
{
    public class ValidationAspect:MethodInterception
    {
        private readonly Type _type;
        public ValidationAspect(Type type)
        {
            //Defenfive
            if (! typeof(IValidator).IsAssignableFrom(type))
            {
                throw new System.Exception("Bu bir validator türü değil");
            }
            _type = type;
        }
        public override void OnBefore(IInvocation invocation)
        {
            var ourObject =(IValidator) Activator.CreateInstance(_type);
            var entityType = _type.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(p => p.GetType() == entityType);
            foreach (var item in entities)
            {
                ValidationTool.Validate(item, ourObject);
            }
        }
    }
}
