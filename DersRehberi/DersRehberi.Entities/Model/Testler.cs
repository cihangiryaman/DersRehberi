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
    
    public partial class Testler
    {
        public int Id { get; set; }
        public int OlusturanPersonelId { get; set; }
        public string TestAdi { get; set; }
    
        public virtual Personeller Personeller { get; set; }
        public virtual Sinavlar Sinavlar { get; set; }
        public virtual Kazanimlar Kazanimlar { get; set; }
        public virtual Konular Konular { get; set; }
        public virtual Ogrenciler Ogrenciler { get; set; }
        public virtual Uniteler Uniteler { get; set; }
    }
}
