using FluentValidation;
using FluentValidationApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationApp.Web.FluentValidator
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name alanı boş geçilemez.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail alanı boş geçilemez.").EmailAddress().WithMessage("Girilen mail, mail kurallarına uygun olmalıdır.");
            RuleFor(x => x.Age).NotEmpty().WithMessage("Age alanı boş geçilemez.").InclusiveBetween(18, 65).WithMessage("Girilen yaş, 18-65 arası olmalıdır.");

        }
    }
}
