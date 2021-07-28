using DersRehberi.BLL.DTOs.Interface;
using DersRehberi.Entities.Model;
using System.Collections.Generic;
using System.Data.Entity;

namespace DersRehberi.BLL.DTOs.Class
{
    public class OgrenciDto : IDto<Ogrenciler>
    {
        public int Id { get; set; }
        public List<string> ErrorMessages { get; set; }
        public bool IsValid { get; set; }
        public string OkulNo { get; set; }
        public int SinifId { get; set; }
        public int VeliId { get; set; }
        //DersRehberiEntities context = new DersRehberiEntities();
        //public DbSet _object { get; set; }

        //public OgrenciDto()
        //{
        //    _object = context.Ogrenciler;
        //}
    }
}
