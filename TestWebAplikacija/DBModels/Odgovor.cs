//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWebAplikacija.DBModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Odgovor
    {
        public int OdgovorId { get; set; }
        public int PitanjeId { get; set; }
        public string Tekst { get; set; }
        public Nullable<bool> Tacan { get; set; }
    
        public virtual Pitanje Pitanje { get; set; }
    }
}
