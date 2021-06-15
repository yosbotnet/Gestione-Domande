using DevExpress.Mvvm.DataModel;
using GestioneDomandeDX;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GestioneDomandeDX.egafEntitiesDataModel {

    /// <summary>
    /// IegafEntitiesUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IegafEntitiesUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The abb_dom_materie_minist entities repository.
        /// </summary>
		IRepository<abb_dom_materie_minist, int> abb_dom_materie_minist { get; }
        
        /// <summary>
        /// The abbinamento_esami_materie entities repository.
        /// </summary>
		IRepository<abbinamento_esami_materie, int> abbinamento_esami_materie { get; }
        
        /// <summary>
        /// The dettaglioregole entities repository.
        /// </summary>
		IRepository<dettaglioregole, Tuple<int, int>> dettaglioregole { get; }
        
        /// <summary>
        /// The domande entities repository.
        /// </summary>
		IRepository<domande, int> domande { get; }
        
        /// <summary>
        /// The esami entities repository.
        /// </summary>
		IRepository<esami, int> esami { get; }
        
        /// <summary>
        /// The regole entities repository.
        /// </summary>
		IRepository<regole, Tuple<int, int>> regole { get; }
        
        /// <summary>
        /// The releaseopere entities repository.
        /// </summary>
		IRepository<releaseopere, int> releaseopere { get; }
        
        /// <summary>
        /// The risposte entities repository.
        /// </summary>
		IRepository<risposte, int> risposte { get; }
        
        /// <summary>
        /// The tipocommissione entities repository.
        /// </summary>
		IRepository<tipocommissione, int> tipocommissione { get; }
        
        /// <summary>
        /// The v_tipipatente entities repository.
        /// </summary>
		IReadOnlyRepository<v_tipipatente> v_tipipatente { get; }
        
        /// <summary>
        /// The v_esami entities repository.
        /// </summary>
		IReadOnlyRepository<v_esami> v_esami { get; }
        
        /// <summary>
        /// The v_regole entities repository.
        /// </summary>
		IReadOnlyRepository<v_regole> v_regole { get; }
        
        /// <summary>
        /// The locks entities repository.
        /// </summary>
		IRepository<locks, int> locks { get; }
        
        /// <summary>
        /// The v_releaseopere entities repository.
        /// </summary>
		IReadOnlyRepository<v_releaseopere> v_releaseopere { get; }
        
        /// <summary>
        /// The v_domerisp entities repository.
        /// </summary>
		IReadOnlyRepository<v_domerisp> v_domerisp { get; }
    }
}
