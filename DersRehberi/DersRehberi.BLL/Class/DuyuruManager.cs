using DersRehberi.BLL.DTOs.Class;
using DersRehberi.BLL.Interface;
using DersRehberi.BLL.ValidationRules;
using DersRehberi.DAL;
using DersRehberi.Entities.Model;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DersRehberi.BLL.Class
{
    public class DuyuruManager : IManager<Duyurular>
    {
        public Repository<Duyurular> repository { get; set; }
        public AbstractValidator<Duyurular> validator { get; set; }
        public ValidationResult result { get; set; }
        DuyuruDto _dto;

        public DuyuruManager()
        {
            repository = new Repository<Duyurular>();
            result = new ValidationResult();
            _dto = new DuyuruDto();
        }

        public int Add(Duyurular duyuru)
        {
            int value = 0;
            validator = new DuyuruValidator();
            result = validator.Validate(duyuru);
            if (result.IsValid)
            {
                value = repository.Add(duyuru);
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    _dto.ErrorMessages.Add(item.ErrorMessage);
                }
            }
            _dto.IsValid = result.IsValid;
            return value;
        }

        public int Delete(Duyurular duyuru)
        {
            return repository.Delete(duyuru);
        }

        public Duyurular Get(Expression<Func<Duyurular, bool>> filter)
        {
            return repository.Get(filter);
        }

        public List<Duyurular> GetList(Expression<Func<Duyurular, bool>> filter = null)
        {
            return repository.GetList(filter);
        }

        public int Update(Duyurular duyuru)
        {
            Duyurular _duyuru = repository.Get(d => d.Id == duyuru.Id);
            _duyuru.Baslik = duyuru.Baslik;
            _duyuru.Icerik = duyuru.Icerik;
            _duyuru.KisaIcerik = duyuru.KisaIcerik;
            _duyuru.ResimDosyaYolu = duyuru.ResimDosyaYolu;
            return repository.Update(_duyuru);
        }
    }
}
