//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Turism
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tara
    {
        public Tara()
        {
            this.OfertaSejurs = new HashSet<OfertaSejur>();
            this.Oras = new HashSet<Ora>();
        }
    
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Continent { get; set; }
        public string Capitala { get; set; }
        public string Populatie { get; set; }
        public string LimbaVorbita { get; set; }
        public string Detaliu { get; set; }
        public Nullable<double> Latitudine { get; set; }
        public Nullable<double> Longitudine { get; set; }
    
        public virtual ICollection<OfertaSejur> OfertaSejurs { get; set; }
        public virtual ICollection<Ora> Oras { get; set; }
    }
}
