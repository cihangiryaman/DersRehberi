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
    
    public partial class Kazanimlar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kazanimlar()
        {
            this.Testler = new HashSet<Testler>();
        }
    
        public int Id { get; set; }
        public int KonuId { get; set; }
        public string KazanimAdi { get; set; }
    
        public virtual Konular Konular { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Testler> Testler { get; set; }
    }
}
