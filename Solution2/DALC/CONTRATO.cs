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
    
    public partial class CONTRATO
    {
        public CONTRATO()
        {
            this.PAGO = new HashSet<PAGO>();
            this.SER_ADICIONAL = new HashSet<SER_ADICIONAL>();
        }
    
        public decimal CONTRATO_ID { get; set; }
        public System.DateTime FECHA { get; set; }
        public string NOMBRE_COLEGIO { get; set; }
        public decimal SUBTOTAL { get; set; }
        public decimal TOTAL { get; set; }
        public decimal TOUR_TOUR_ID { get; set; }
        public decimal AGENTE_AGENTE_ID { get; set; }
    
        public virtual AGENTE AGENTE { get; set; }
        public virtual TOUR TOUR { get; set; }
        public virtual ICollection<PAGO> PAGO { get; set; }
        public virtual ICollection<SER_ADICIONAL> SER_ADICIONAL { get; set; }
    }
}
