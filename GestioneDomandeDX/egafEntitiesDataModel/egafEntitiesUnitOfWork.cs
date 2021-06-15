using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using GestioneDomandeDX;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GestioneDomandeDX.egafEntitiesDataModel {

    /// <summary>
    /// A egafEntitiesUnitOfWork instance that represents the run-time implementation of the IegafEntitiesUnitOfWork interface.
    /// </summary>
    public class egafEntitiesUnitOfWork : DbUnitOfWork<egafEntities>, IegafEntitiesUnitOfWork {

        public egafEntitiesUnitOfWork(Func<egafEntities> contextFactory)
            : base(contextFactory) {
        }

        IRepository<abb_dom_materie_minist, int> IegafEntitiesUnitOfWork.abb_dom_materie_minist {
            get { return GetRepository(x => x.Set<abb_dom_materie_minist>(), (abb_dom_materie_minist x) => x.AB9_ID); }
        }

        IRepository<abbinamento_esami_materie, int> IegafEntitiesUnitOfWork.abbinamento_esami_materie {
            get { return GetRepository(x => x.Set<abbinamento_esami_materie>(), (abbinamento_esami_materie x) => x.AB5_ID); }
        }

        IRepository<dettaglioregole, Tuple<int, int>> IegafEntitiesUnitOfWork.dettaglioregole {
            get { return GetRepository(x => x.Set<dettaglioregole>(), (dettaglioregole x) => Tuple.Create(x.DR_ID, x.DR_PROG)); }
        }

        IRepository<domande, int> IegafEntitiesUnitOfWork.domande {
            get { return GetRepository(x => x.Set<domande>(), (domande x) => x.DO_ID); }
        }

        IRepository<esami, int> IegafEntitiesUnitOfWork.esami {
            get { return GetRepository(x => x.Set<esami>(), (esami x) => x.ES_ID); }
        }

        IRepository<regole, Tuple<int, int>> IegafEntitiesUnitOfWork.regole {
            get { return GetRepository(x => x.Set<regole>(), (regole x) => Tuple.Create(x.RE_ID, x.RE_PROG)); }
        }

        IRepository<releaseopere, int> IegafEntitiesUnitOfWork.releaseopere {
            get { return GetRepository(x => x.Set<releaseopere>(), (releaseopere x) => x.RO_ID); }
        }

        IRepository<risposte, int> IegafEntitiesUnitOfWork.risposte {
            get { return GetRepository(x => x.Set<risposte>(), (risposte x) => x.RI_ID); }
        }

        IRepository<tipocommissione, int> IegafEntitiesUnitOfWork.tipocommissione {
            get { return GetRepository(x => x.Set<tipocommissione>(), (tipocommissione x) => x.TC_ID); }
        }

        IReadOnlyRepository<v_tipipatente> IegafEntitiesUnitOfWork.v_tipipatente {
            get { return GetReadOnlyRepository(x => x.Set<v_tipipatente>()); }
        }

        IReadOnlyRepository<v_esami> IegafEntitiesUnitOfWork.v_esami {
            get { return GetReadOnlyRepository(x => x.Set<v_esami>()); }
        }

        IReadOnlyRepository<v_regole> IegafEntitiesUnitOfWork.v_regole {
            get { return GetReadOnlyRepository(x => x.Set<v_regole>()); }
        }

        IRepository<locks, int> IegafEntitiesUnitOfWork.locks {
            get { return GetRepository(x => x.Set<locks>(), (locks x) => x.ID); }
        }

        IReadOnlyRepository<v_releaseopere> IegafEntitiesUnitOfWork.v_releaseopere {
            get { return GetReadOnlyRepository(x => x.Set<v_releaseopere>()); }
        }

        IReadOnlyRepository<v_domerisp> IegafEntitiesUnitOfWork.v_domerisp {
            get { return GetReadOnlyRepository(x => x.Set<v_domerisp>()); }
        }
    }
}
