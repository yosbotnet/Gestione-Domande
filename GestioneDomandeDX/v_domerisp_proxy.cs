using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace GestioneDomandeDX
{
    public enum Bloccata
    {
        [Description("")]
        Nessuna = 0,
        [Description("Bloccata")]
        Bloccata,
        [Description("Errata")]
        Errata
    }
    class v_domerisp_proxy : v_domerisp, IEquatable<v_domerisp>
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
        public string DO_TESTODE
        {
            get { return tutto.DO_TESTODE; }
            set
            {
                d.DO_TESTODE = value;
                tutto.DO_TESTODE = value;
            }
        }
        public string DO_TESTOFR
        {
            get { return tutto.DO_TESTOFR; }
            set
            {
                d.DO_TESTOFR = value;
                tutto.DO_TESTOFR = value;
            }
        }
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
        public string DO_IMG {
            get
            {
                return d.DO_IMG;
            }
            set
            {
                d.DO_IMG = value;
                tutto.DO_IMG = value;
            }
        }
        public string DO_IMG2
        {
            get
            {
                return d.DO_IMG2;
            }
            set
            {
                d.DO_IMG2 = value;
                tutto.DO_IMG2 = value;
            }
        }
        [EnumDataType(typeof(Bloccata))]
        public Nullable<int> DO_FLAG_BLOCCATA
        {
            get
            {
                return d.DO_FLAG_BLOCCATA;
            }
            set
            {
                d.DO_FLAG_BLOCCATA = value;
                tutto.DO_FLAG_BLOCCATA = value;
            }

        }
        public string DO_NOTE
        {
            get
            {
                return d.DO_NOTE;
            }
            set
            {
                d.DO_NOTE = value;
                tutto.DO_NOTE = value;
            }
        }
        [EnumDataType(typeof(Bloccata))]
        public Nullable<int> RI_FLAG_BLOCCATA
        {
            get
            {
                return r.RI_FLAG_BLOCCATA;
            }
            set
            {
                r.RI_FLAG_BLOCCATA = value;
                tutto.RI_FLAG_BLOCCATA = value;
            }

        }
        public string RI_NOTE
        {
            get
            {
                return r.RI_NOTE;
            }
            set
            {
                r.RI_NOTE = value;
                tutto.RI_NOTE = value;
            }
        }
        public string DO_ALTROTESTO {
            get
            {
                return d.DO_ALTROTESTO;
            }
            set
            {
                d.DO_ALTROTESTO = value;
                tutto.DO_ALTROTESTO = value;
            }
        }
        public string DO_TESTO_AIUTO
        {
            get
            {
                return d.DO_TESTO_AIUTO;
            }
            set
            {
                d.DO_TESTO_AIUTO = value;
                tutto.DO_TESTO_AIUTO = value;
            }
        }
        public string RI_IMG
        {
            get
            {
                return r.RI_IMG;
            }
            set
            {
                r.RI_IMG = value;
                tutto.RI_IMG = value;
            }
        }
        public string RI_IMG2
        {
            get
            {
                return r.RI_IMG2;
            }
            set
            {
                r.RI_IMG2 = value;
                tutto.RI_IMG2 = value;
            }
        }
        public string RI_ALTROTESTO
        {
            get
            {
                return r.RI_ALTROTESTO;
            }
            set
            {
                r.RI_ALTROTESTO = value;
                tutto.RI_ALTROTESTO = value;
            }
        }
        public string DO_MULTIMEDIALE
        {
            get
            {
                return d.DO_MULTIMEDIALE;
            }
            set
            {
                d.DO_MULTIMEDIALE = value;
                tutto.DO_MULTIMEDIALE = value;
            }
        }
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

        public bool Equals(v_domerisp vdp)
        {

            return DO_ID == vdp.DO_ID &&
                   RI_ID == vdp.RI_ID &&
                   DO_TESTO == vdp.DO_TESTO &&
                   RI_TESTOORDINE == vdp.RI_TESTOORDINE &&
                   RI_TESTO == vdp.RI_TESTO &&
                   RI_TESTOFR == vdp.RI_TESTOFR &&
                   RI_TESTODE == vdp.RI_TESTODE &&
                   RI_VF == vdp.RI_VF &&
                   DO_IMG == vdp.DO_IMG &&
                   DO_IMG2 == vdp.DO_IMG2 &&
                   DO_FLAG_BLOCCATA == vdp.DO_FLAG_BLOCCATA &&
                   DO_NOTE == vdp.DO_NOTE &&
                   RI_FLAG_BLOCCATA == vdp.RI_FLAG_BLOCCATA &&
                   RI_NOTE == vdp.RI_NOTE &&
                   DO_ALTROTESTO == vdp.DO_ALTROTESTO &&
                   DO_TESTO_AIUTO == vdp.DO_TESTO_AIUTO &&
                   RI_IMG == vdp.RI_IMG &&
                   RI_IMG2 == vdp.RI_IMG2 &&
                   RI_ALTROTESTO == vdp.RI_ALTROTESTO &&
                   DO_MULTIMEDIALE == vdp.DO_MULTIMEDIALE;

        }
    }
}
