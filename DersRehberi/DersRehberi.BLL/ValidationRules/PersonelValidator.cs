using DersRehberi.Entities.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersRehberi.BLL.ValidationRules
{
    public class PersonelValidator : AbstractValidator<Personeller>
    {
        public PersonelValidator()
        {
            RuleFor(p => p.UnvanId)
                .NotEmpty()
                .WithMessage("Personelin unvanı boş bırakılamaz");
            RuleFor(p => p.OkulId)
                .NotEmpty()
                .WithMessage("Personelin okulu boş bırakılamaz");
            RuleFor(p => p.BransId)
                .NotEmpty()
                .WithMessage("Personelin branşı boş geçilemez");
        }
    }
}
