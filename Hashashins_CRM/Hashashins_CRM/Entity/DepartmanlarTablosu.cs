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
    
    public partial class DepartmanlarTablosu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DepartmanlarTablosu()
        {
            this.PersonelTablosu = new HashSet<PersonelTablosu>();
        }
    
        public int Departman_ID { get; set; }
        public string Departman_Adi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonelTablosu> PersonelTablosu { get; set; }
    }
}
