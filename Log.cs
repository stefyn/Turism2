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
    
    public partial class Log
    {
        public int ID { get; set; }
        public Nullable<int> IdUser { get; set; }
        public Nullable<System.DateTime> DataActiune { get; set; }
        public string Actiune { get; set; }
        public string StareActiune { get; set; }
    
        public virtual User User { get; set; }
    }
}
