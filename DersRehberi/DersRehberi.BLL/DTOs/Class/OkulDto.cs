using DersRehberi.BLL.DTOs.Interface;
using DersRehberi.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersRehberi.BLL.DTOs.Class
{
    public class OkulDto : IDto<Okullar>
    {
        public int Id { get; set; }
        public List<string> ErrorMessages { get; set; }
        public bool IsValid { get; set; }
        public string OkulIsmi { get; set; }
    }
}
