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
    
    public partial class MATRICULA
    {
        public int ID_MATRICULA { get; set; }
        public Nullable<int> ID_ALUMN { get; set; }
        public Nullable<int> ID_NIVEL { get; set; }
        public Nullable<System.DateTime> FECHA_HORA { get; set; }
        public Nullable<decimal> COSTO { get; set; }
        public string PARALELO { get; set; }
    
        public virtual ALUMNOS ALUMNOS { get; set; }
        public virtual NIVELES NIVELES { get; set; }
    }
}
