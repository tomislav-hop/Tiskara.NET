//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PI_PROJEKT.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class izdatnica
    {
        public izdatnica()
        {
            this.stavke_izdatnice = new HashSet<stavke_izdatnice>();
        }
    
        public int id_izdatnica { get; set; }
        public System.DateTime datum { get; set; }
        public Nullable<int> id_korisnik { get; set; }
        public string izdaje { get; set; }
    
        public virtual korisnici korisnici { get; set; }
        public virtual ICollection<stavke_izdatnice> stavke_izdatnice { get; set; }
    }
}