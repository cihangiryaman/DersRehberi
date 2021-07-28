using DersRehberi.BLL.DTOs.Interface;
using DersRehberi.DAL;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DersRehberi.BLL.Interface
{
    public interface IManager<T> where T : class, new()
    {
        Repository<T> repository { get; set; }
        AbstractValidator<T> validator { get; set; }
        ValidationResult result { get; set; }

        int Add(T p);

        int Delete(T p);

        int Update(T p);

        List<T> GetList(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);
    }
}
