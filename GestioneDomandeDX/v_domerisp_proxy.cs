using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
namespace GestioneDomandeDX
{
    class v_domerisp_proxy : v_domerisp
    {
        private egafEntities ctx;
        private domande _d;
        private risposte _r;
        private v_domerisp tutto;
        public v_domerisp_proxy(v_domerisp vdp, egafEntities con)
        {
            ctx = con;
            tutto = vdp;
                 
        }
        public int DO_ID { get { return d.DO_ID; } }
        public int RI_ID { get { return r.RI_ID; } }
        public string DO_TESTO {
            get {
                return tutto.DO_TESTO;
            }
            set {
                d.DO_TESTO = value;
                tutto.DO_TESTO = value;
            }
        }
        public string RI_TESTOORDINE
        {
            get { return tutto.RI_TESTOORDINE; }
            set
            {
                r.RI_TESTOORDINE = value;
                tutto.RI_TESTOORDINE = value;
            }
        }
        public string DO_TESTODE { get; set; }
        public string DO_TESTOFR { get; set; }
        public string RI_TESTO {
            get { return tutto.RI_TESTO; }
            set { r.RI_TESTO = value;
                  tutto.RI_TESTO = value;
            } }
        public string RI_TESTODE {
            get { return tutto.RI_TESTODE; }
            set
            {   r.RI_TESTODE = value;
                tutto.RI_TESTODE = value; }
        }
        public string RI_TESTOFR
        {
            get { return tutto.RI_TESTOFR; }
            set
            {
                r.RI_TESTOFR = value;
                tutto.RI_TESTOFR = value;
            }
        }
        public string RI_VF
        {
            get { return tutto.RI_VF; }
            set
            {
                r.RI_VF = value;
                tutto.RI_VF = value;
            }
        }
        public string DO_IMG { get; set; }
        public string DO_IMG2 { get; set; }
        public Nullable<int> DO_FLAG_BLOCCATA { get; set; }
        public string DO_NOTE { get; set; }
        public Nullable<int> RI_FLAG_BLOCCATA { get; set; }
        public string RI_NOTE { get; set; }
        public string DO_ALTROTESTO { get; set; }
        public string DO_TESTO_AIUTO { get; set; }
        public string RI_IMG { get; set; }
        public string RI_IMG2 { get; set; }
        public string RI_ALTROTESTO { get; set; }
        public string DO_MULTIMEDIALE { get; set; }
        private domande d
        {
            get {
                if (_d == null)
                {
                    _d = ctx.domande.Where(dom => dom.DO_ID == tutto.DO_ID).FirstOrDefault();

                }
                return _d;
            }
            
        }
        private risposte r
        {
            get
            {
                if(_r == null)
                    _r = d.risposte.Where(ri => ri.RI_ID == tutto.RI_ID).FirstOrDefault();
                return _r;
            }
        }
    }
}
