using Domain;
using FluentValidation;
using System;

namespace WebApplication7.Validation
{
    public class PersonValidation : AbstractValidator<Person>
    {
        public PersonValidation()
        {
            RuleFor(a => a.Datetime)
                    .LessThanOrEqualTo(a => DateTime.Now).WithMessage("Datetime must be less than current datetime");
            RuleFor(a => a.Firstname).NotEmpty().Length(0, 50);
            RuleFor(a => a.Lastname).NotEmpty().Length(0, 50);
            RuleFor(a => a.PAdress).NotEmpty();
            RuleFor(a => a.PAdress.Country).NotEmpty().WithMessage("Pleas fill in Adress");


        }
    }
}
