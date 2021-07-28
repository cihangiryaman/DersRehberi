using DersRehberi.BLL.DTOs.Class;
using DersRehberi.BLL.DTOs.Interface;
using DersRehberi.BLL.Interface;
using DersRehberi.BLL.ValidationRules;
using DersRehberi.DAL;
using DersRehberi.Entities.Model;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DersRehberi.BLL.Class
{
    public class OgrenciManager : IManager<Ogrenciler>
    {
        public Repository<Ogrenciler> repository { get; set; }
        public AbstractValidator<Ogrenciler> validator { get; set; }
        public ValidationResult result { get; set; }
        OgrenciDto _dto;

        public OgrenciManager()
        {
            repository = new Repository<Ogrenciler>();
            result = new ValidationResult();
            _dto = new OgrenciDto();
        }

        public int Add(Ogrenciler ogrenci)
        {
            int value = 0;
            validator = new OgrenciValidator();
            result = validator.Validate(ogrenci);
            if (result.IsValid)
            {
                value = repository.Add(ogrenci);
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

        public int Delete(Ogrenciler ogrenci)
        {
            return repository.Delete(ogrenci);
        }

        public Ogrenciler Get(Expression<Func<Ogrenciler, bool>> filter)
        {
            return repository.Get(filter);
        }

        public List<Ogrenciler> GetList(Expression<Func<Ogrenciler, bool>> filter = null)
        {
            return repository.GetList(filter);
        }

        public int Update(Ogrenciler ogrenci)
        {
            Ogrenciler _ogrenci = repository.Get(o => o.KisiId == ogrenci.KisiId);
            _ogrenci.OkulNo = ogrenci.OkulNo;
            _ogrenci.SinifId = ogrenci.SinifId;
            _ogrenci.VeliId = ogrenci.VeliId;
            return repository.Update(_ogrenci);
        }
    }
}
