using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(s => s.StudentFirstName).NotEmpty().WithMessage("Boş olmamalı.");
            RuleFor(s => s.StudentLastName).NotEmpty().WithMessage("Boş olmamalı.");
            RuleFor(s => s.StudentCardNumber).NotEmpty().WithMessage("Boş olmamalı.");
            RuleFor(s => s.StudentSchoolId).NotEmpty().WithMessage("Boş olmamalı.");
            RuleFor(s => s.StudentCardNumber).GreaterThan(0);
            RuleFor(s => s.StudentSchoolId).GreaterThan(0);


        }
    }
}
