using DersRehberi.Entities.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersRehberi.BLL.ValidationRules
{
    public class DuyuruValidator : AbstractValidator<Duyurular>
    {
        public DuyuruValidator()
        {
            RuleFor(d => d.Baslik)
                .NotEmpty()
                .WithMessage("Duyurunun bir başlığı olmalı");
            RuleFor(d => d.Baslik)
                .MinimumLength(10)
                .WithMessage("Duyurunun başlığı çok kısa");
            RuleFor(d => d.Icerik)
                .NotEmpty()
                .WithMessage("Duyuruya içerik girilmeli");
            RuleFor(d => d.Icerik)
                .MinimumLength(10)
                .WithMessage("Duyurunun içeriği çok kısa");
            RuleFor(d => d.KisaIcerik)
                .NotEmpty()
                .WithMessage("Duyurunun özeti olamalı");
            RuleFor(d => d.KisaIcerik)
                .MinimumLength(10)
                .WithMessage("Duyurunun özeti çok kısa");
        }
    }
}
