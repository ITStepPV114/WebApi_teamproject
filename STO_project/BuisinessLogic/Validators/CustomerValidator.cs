using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using FluentValidation;

namespace Core.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator() 
        {
            RuleFor(c=>c.FirstName).NotEmpty()
                .MaximumLength(20)
                .MinimumLength(4);
            RuleFor(c => c.LastName).NotEmpty()
                .MaximumLength(50)
                .MinimumLength(4);

            RuleFor(c => c.Email).NotEmpty();
            RuleFor(c => c.PhoneNumber).NotEmpty();
        }  
    }
}
