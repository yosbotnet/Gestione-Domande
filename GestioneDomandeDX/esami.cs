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
    
    public partial class esami
    {
        public esami()
        {
            this.domande = new HashSet<domande>();
        }
    
        public int ES_ID { get; set; }
        public string ES_MNEMO { get; set; }
        public string ES_DESCRIZIONE { get; set; }
        public Nullable<int> ES_RE_ID { get; set; }
        public string ES_SIGLAMULTIMEDIALE { get; set; }
        public string ES_SIGLA { get; set; }
        public Nullable<int> ES_TC_ID { get; set; }
        public Nullable<byte> ES_ESAME_APERTO { get; set; }
        public Nullable<int> ES_MONTE_ORE { get; set; }
        public Nullable<int> ES_MAX_ASSENZE_ORE { get; set; }
        public Nullable<int> ES_MAX_ASSENZE_PERC { get; set; }
        public string ES_BROWSERMULTIMEDIALE { get; set; }
        public string ES_SIGLABREVE { get; set; }
        public string ES_DESCRIZIONEATTESTATO { get; set; }
        public string ES_MULTIESBASE { get; set; }
        public string ES_MULTIESLIVELLO { get; set; }
        public string ES_ORDINEAGGREGAZIONE { get; set; }
        public Nullable<byte> ES_STAMPAATTESTATO { get; set; }
        public Nullable<byte> ES_NONSELEZIONABILE { get; set; }
        public Nullable<int> ES_ORDINAMENTO { get; set; }
        public Nullable<byte> ES_REVISIONE { get; set; }
        public string ES_DESCRIZIONE_APP { get; set; }
        public Nullable<byte> ES_ESCLUDI_DA_APP { get; set; }
    
        public virtual tipocommissione tipocommissione { get; set; }
        public virtual ICollection<domande> domande { get; set; }
    }
}
