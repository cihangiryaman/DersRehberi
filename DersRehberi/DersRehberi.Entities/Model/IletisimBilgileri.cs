//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DersRehberi.Entities.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class IletisimBilgileri
    {
        public int Id { get; set; }
        public int SahipId { get; set; }
        public string TelefonNumarasi { get; set; }
        public string EPostaAdresi { get; set; }
        public Nullable<int> AdresId { get; set; }
    
        public virtual Adresler Adresler { get; set; }
        public virtual Kisiler Kisiler { get; set; }
        public virtual Okullar Okullar { get; set; }
    }
}
