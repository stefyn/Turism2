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
    
    public partial class Hotel
    {
        public Hotel()
        {
            this.Cameras = new HashSet<Camera>();
            this.Comentarius = new HashSet<Comentariu>();
        }
    
        public int ID { get; set; }
        public Nullable<int> IdOras { get; set; }
        public string Denumire { get; set; }
        public Nullable<double> Longitudine { get; set; }
        public Nullable<double> Latitudine { get; set; }
        public Nullable<int> NrCamere { get; set; }
        public Nullable<bool> PermisiuneAnimale { get; set; }
        public string TipCazare { get; set; }
    
        public virtual ICollection<Camera> Cameras { get; set; }
        public virtual ICollection<Comentariu> Comentarius { get; set; }
    }
}
