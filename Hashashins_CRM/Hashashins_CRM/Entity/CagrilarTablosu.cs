//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hashashins_CRM.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class CagrilarTablosu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CagrilarTablosu()
        {
            this.CagriDetaylariTablosu = new HashSet<CagriDetaylariTablosu>();
        }
    
        public int Cagri_ID { get; set; }
        public Nullable<int> Cagri_Firmasi { get; set; }
        public string Konu { get; set; }
        public string Aciklama { get; set; }
        public Nullable<bool> Durum { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    
        public virtual FirmalarTablosu FirmalarTablosu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CagriDetaylariTablosu> CagriDetaylariTablosu { get; set; }
    }
}
