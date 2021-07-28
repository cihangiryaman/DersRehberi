using DersRehberi.Entities.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersRehberi.BLL.ValidationRules
{
    public class OkulValidator : AbstractValidator<Okullar>
    {
        public OkulValidator()
        {
            RuleFor(o => o.OkulIsmi)
                .NotEmpty()
                .WithMessage("Okulun ismi boş bırakılamaz");
            RuleFor(o => o.OkulIsmi)
                .MinimumLength(10)
                .WithMessage("Okulun ismi çok kısa. Okulun ismi en az 10 haneli olmalıdır");
        }
    }
}
