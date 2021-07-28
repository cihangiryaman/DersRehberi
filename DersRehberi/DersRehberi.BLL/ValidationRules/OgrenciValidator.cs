using DersRehberi.Entities.Model;
using FluentValidation;

namespace DersRehberi.BLL.ValidationRules
{
    public class OgrenciValidator : AbstractValidator<Ogrenciler>
    {
        public OgrenciValidator(string girilenOkulNo = null)
        {
            RuleFor(o => o.OkulNo)
                .NotEmpty()
                .WithMessage("Okul boş geçilemez");
            RuleFor(o => o.VeliId)
                .NotEmpty()
                .WithMessage("Veli boş geçilemez");
            RuleFor(o => o.SinifId)
                .NotEmpty()
                .WithMessage("Sınıf boş geçilemez");

            if (girilenOkulNo != null)
            {
                RuleFor(o => o.OkulNo)
                    .Equal(girilenOkulNo)
                    .WithMessage("Okul numarası yanlış");
            }//***********
        }
    }
}
