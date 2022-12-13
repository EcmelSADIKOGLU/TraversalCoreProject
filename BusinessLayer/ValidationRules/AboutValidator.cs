using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlığı boş bırakamazsınız.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Başlığı boş bırakamazsınız.");
            RuleFor(x => x.Image1URL).NotEmpty().WithMessage("Başlığı boş bırakamazsınız.");
            RuleFor(x => x.Title2).NotEmpty().WithMessage("Başlığı boş bırakamazsınız.");
            RuleFor(x => x.Description2).NotEmpty().WithMessage("Başlığı boş bırakamazsınız.");
        }
    }
}
