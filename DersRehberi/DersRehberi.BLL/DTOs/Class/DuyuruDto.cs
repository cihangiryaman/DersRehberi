using DersRehberi.BLL.DTOs.Interface;
using DersRehberi.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersRehberi.BLL.DTOs.Class
{
    public class DuyuruDto : IDto<Duyurular>
    {
        public int Id { get; set; }
        public List<string> ErrorMessages { get; set; }
        public bool IsValid { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string KisaIcerik { get; set; }
        public string ResimDosyaYolu { get; set; }
    }
}
