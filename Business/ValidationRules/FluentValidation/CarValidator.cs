using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Id).NotEmpty();
            RuleFor(c => c.CarName).MaximumLength(2);
            RuleFor(c => c.CarName).NotEmpty();
            //RuleFor(c => c.CarName).Must(StartWithB).WithMessage("Araba ismi B harfi ile başlamalıdır.");
        }

        //private bool StartWithB(string arg)
        //{
        //    return arg.StartsWith("B");
        //}
    }
}
