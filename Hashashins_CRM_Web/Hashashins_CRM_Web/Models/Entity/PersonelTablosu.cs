//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hashashins_CRM_Web.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonelTablosu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonelTablosu()
        {
            this.GorevlerTablosu = new HashSet<GorevlerTablosu>();
            this.GorevlerTablosu1 = new HashSet<GorevlerTablosu>();
        }
    
        public int Personel_ID { get; set; }
        public string Personel_Adi { get; set; }
        public string Personel_Soyadi { get; set; }
        public string Mail_Adresi { get; set; }
        public string Telefon_No { get; set; }
        public Nullable<int> Departman { get; set; }
        public Nullable<bool> Durum { get; set; }
        public string Sifre { get; set; }
    
        public virtual DepartmanlarTablosu DepartmanlarTablosu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GorevlerTablosu> GorevlerTablosu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GorevlerTablosu> GorevlerTablosu1 { get; set; }
    }
}
