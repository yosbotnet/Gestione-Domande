//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestioneDomandeDX
{
    using System;
    using System.Collections.Generic;
    
    public partial class v_regole
    {
        public int RE_ID { get; set; }
        public int RE_PROG { get; set; }
        public string RE_DESCRIZIONE { get; set; }
        public Nullable<int> RE_RISXDOM { get; set; }
        public string RE_TIPOREGOLA { get; set; }
        public Nullable<int> RE_LIMITE_RISPFALSE { get; set; }
        public Nullable<int> RE_LIMITE_MIN_RISPFALSE { get; set; }
        public Nullable<int> Risposte_libere { get; set; }
    }
}
