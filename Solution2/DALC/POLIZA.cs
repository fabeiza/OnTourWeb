//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class POLIZA
    {
        public POLIZA()
        {
            this.TOUR = new HashSet<TOUR>();
        }
    
        public decimal POLIZA_ID { get; set; }
        public System.DateTime FECHA_COBERTURA { get; set; }
        public decimal SUMA_ASEGURADA { get; set; }
        public decimal PRIMA { get; set; }
        public string DESCRIPCION { get; set; }
    
        public virtual ICollection<TOUR> TOUR { get; set; }
    }
}
