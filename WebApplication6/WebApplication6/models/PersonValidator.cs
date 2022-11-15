using FluentValidation;
using System;

namespace WebApplication6.models {


public class PersonValidator : AbstractValidator<Person> 
    {
        public PersonValidator() {
            RuleFor(a => a.Datetime)
                    .LessThanOrEqualTo(a => DateTime.Now).WithMessage("Datetime must be less than current datetime");
            RuleFor(a => a.FirstName).NotEmpty().Length(0, 50);               
            RuleFor(a => a.LastName).NotEmpty().Length(0, 50);
            RuleFor(a => a.JobPosition).NotEmpty().Length(0, 50);
            RuleFor(a => a.Salary).GreaterThan(0).LessThan(10000);
            RuleFor(a => a.WorkExperience).NotEmpty();
            RuleFor(a => a.PersonAdress).NotEmpty();
            RuleFor(a => a.PersonAdress.Country).NotEmpty().WithMessage("Pleas fill in Adress");
        
        
        }
        

    }



}
