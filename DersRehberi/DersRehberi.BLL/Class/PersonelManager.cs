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
    public class PersonelManager : IManager<Personeller>
    {
        public Repository<Personeller> repository { get; set; }
        public AbstractValidator<Personeller> validator { get; set; }
        public ValidationResult result { get; set; }
        public IDto<Personeller> dto { get; set; }

        public PersonelManager()
        {
            repository = new Repository<Personeller>();
            result = new ValidationResult();
            dto = new PersonelDto();
        }

        public int Add(Personeller personel)
        {
            int value = 0;
            validator = new PersonelValidator();
            result = validator.Validate(personel);
            if (result.IsValid)
            {
                value = repository.Add(personel);
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    dto.ErrorMessages.Add(item.ErrorMessage);
                }
            }
            dto.IsValid = result.IsValid;
            return value;
        }

        public int Delete(Personeller personel)
        {
            return repository.Delete(personel);
        }

        public Personeller Get(Expression<Func<Personeller, bool>> filter)
        {
            return repository.Get(filter);
        }

        public List<Personeller> GetList(Expression<Func<Personeller, bool>> filter = null)
        {
            return repository.GetList(filter);
        }

        public int Update(Personeller personel)
        {
            Personeller _personel = repository.Get(p => p.KisilId == personel.KisilId);
            _personel.OkulId = personel.OkulId;
            _personel.UnvanId = personel.UnvanId;
            _personel.BransId = personel.BransId;
            return repository.Update(_personel);           
        }
    }
}
