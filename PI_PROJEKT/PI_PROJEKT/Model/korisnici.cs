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
    
    public partial class korisnici
    {
        public korisnici()
        {
            this.izdatnica = new HashSet<izdatnica>();
            this.narudzbenica = new HashSet<narudzbenica>();
            this.primka = new HashSet<primka>();
            this.racun = new HashSet<racun>();
        }
    
        public int id_korisnik { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string lozinka { get; set; }
        public string ziro_racun { get; set; }
        public string tel_broj { get; set; }
        public string korisnicko_ime { get; set; }
        public Nullable<int> status { get; set; }
    
        public virtual ICollection<izdatnica> izdatnica { get; set; }
        public virtual ICollection<narudzbenica> narudzbenica { get; set; }
        public virtual ICollection<primka> primka { get; set; }
        public virtual ICollection<racun> racun { get; set; }
    }
}
