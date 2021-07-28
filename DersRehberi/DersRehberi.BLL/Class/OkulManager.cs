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
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DersRehberi.BLL.Class
{
    public class OkulManager : IManager<Okullar>
    {
        public Repository<Okullar> repository { get; set; }
        public AbstractValidator<Okullar> validator { get; set; }
        public ValidationResult result { get; set; }
        OkulDto _dto;

        public OkulManager()
        {
            repository = new Repository<Okullar>();
            result = new ValidationResult();
            _dto = new OkulDto();
        }


        public int Add(Okullar okul)
        {
            int value = 0;
            validator = new OkulValidator();
            result = validator.Validate(okul);
            if (result.IsValid)
            {
                value = repository.Add(okul);
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

        public int Delete(Okullar okul)
        {
            return repository.Delete(okul);
        }

        public Okullar Get(Expression<Func<Okullar, bool>> filter)
        {
            return repository.Get(filter);
        }

        public List<Okullar> GetList(Expression<Func<Okullar, bool>> filter = null)
        {
            return repository.GetList(filter);
        }

        public int Update(Okullar okul)
        {
            Okullar _okul = new Okullar();
            _okul.OkulIsmi = okul.OkulIsmi;
            return repository.Update(_okul);
        }
    }
}
