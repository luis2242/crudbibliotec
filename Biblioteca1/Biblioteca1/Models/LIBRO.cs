//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Biblioteca1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LIBRO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LIBRO()
        {
            this.BIBLIOTECA = new HashSet<BIBLIOTECA>();
        }
    
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public string AUTOR { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BIBLIOTECA> BIBLIOTECA { get; set; }
    }
}
