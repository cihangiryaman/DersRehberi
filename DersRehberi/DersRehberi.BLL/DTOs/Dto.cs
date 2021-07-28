using DersRehberi.BLL.DTOs.Interface;
using DersRehberi.DAL;
using DersRehberi.Entities.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersRehberi.BLL.DTOs
{
    public class Dto<T> : IDto<T> where T : class, new()
    {
        public int Id { get; set; }
        public List<string> ErrorMessages { get; set; }
        public bool IsValid { get; set; }
        Repository<T> repository = new Repository<T>();
        DersRehberiEntities context = new DersRehberiEntities();
        DbSet<T> _object;

        public Dto()
        {
            _object = context.Set<T>();
        }


    }
}
