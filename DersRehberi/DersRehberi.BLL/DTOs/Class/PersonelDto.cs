using DersRehberi.BLL.DTOs.Interface;
using DersRehberi.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersRehberi.BLL.DTOs.Class
{
    public class PersonelDto : IDto<Personeller>
    {
        public enum PersonelType
        {
            Ogretmen,
            MudurYardimcisi,
            Mudur
        }

        public int Id { get; set; }
        public List<string> ErrorMessages { get; set; }
        public bool IsValid { get; set; }

        public int UnvanId { get; set; }
        public int BransId { get; set; }
        public int OkulId { get; set; }
    }
}
