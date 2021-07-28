using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DersRehberi.DAL.Interface
{
    public interface IRepository<T>
    {
        int Add(T p);

        int Delete(T p);

        int Update(T p);

        List<T> GetList(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);
    }
}
