//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema_Calificacion.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class REPRESENTANTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REPRESENTANTE()
        {
            this.ALUMNOS = new HashSet<ALUMNOS>();
        }
    
        public int ID_REPR { get; set; }
        public string NOMBRE_REPR { get; set; }
        public string APELLIDO_REPR { get; set; }
        public string CEDULA_REPR { get; set; }
        public string TRABAJO_REPR { get; set; }
        public string DIR_TRABAJO_REPR { get; set; }
        public string TLF_TRABAJO_REPR { get; set; }
        public string TELEFONO_REPR { get; set; }
        public string CELULAR_REPR { get; set; }
        public string ROL_REPR_REPR { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALUMNOS> ALUMNOS { get; set; }
    }
}