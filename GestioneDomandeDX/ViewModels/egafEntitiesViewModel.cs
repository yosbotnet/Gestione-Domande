using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using GestioneDomandeDX.egafEntitiesDataModel;

namespace GestioneDomandeDX.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the egafEntities data model.
    /// </summary>
    public partial class egafEntitiesViewModel : DocumentsViewModel<egafEntitiesModuleDescription, IegafEntitiesUnitOfWork> {

		const string TablesGroup = "Tables";

		const string ViewsGroup = "Views";
	
        /// <summary>
        /// Creates a new instance of egafEntitiesViewModel as a POCO view model.
        /// </summary>
        public static egafEntitiesViewModel Create() {
            return ViewModelSource.Create(() => new egafEntitiesViewModel());
        }

		
        /// <summary>
        /// Initializes a new instance of the egafEntitiesViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the egafEntitiesViewModel type without the POCO proxy factory.
        /// </summary>
        protected egafEntitiesViewModel()
		    : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override egafEntitiesModuleDescription[] CreateModules() {
			return new egafEntitiesModuleDescription[] {
                new egafEntitiesModuleDescription( "abb dom materie minist", "abb_dom_materie_ministCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.abb_dom_materie_minist)),
                new egafEntitiesModuleDescription( "abbinamento esami materie", "abbinamento_esami_materieCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.abbinamento_esami_materie)),
                new egafEntitiesModuleDescription( "dettaglioregole", "dettaglioregoleCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.dettaglioregole)),
                new egafEntitiesModuleDescription( "domande", "domandeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.domande)),
                new egafEntitiesModuleDescription( "esami", "esamiCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.esami)),
                new egafEntitiesModuleDescription( "regole", "regoleCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.regole)),
                new egafEntitiesModuleDescription( "releaseopere", "releaseopereCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.releaseopere)),
                new egafEntitiesModuleDescription( "risposte", "risposteCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.risposte)),
                new egafEntitiesModuleDescription( "tipocommissione", "tipocommissioneCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.tipocommissione)),
                new egafEntitiesModuleDescription( "locks", "locksCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.locks)),
                new egafEntitiesModuleDescription("v tipipatente", "v_tipipatenteCollectionView", ViewsGroup),
                new egafEntitiesModuleDescription("v esami", "v_esamiCollectionView", ViewsGroup),
                new egafEntitiesModuleDescription("v regole", "v_regoleCollectionView", ViewsGroup),
                new egafEntitiesModuleDescription("v releaseopere", "v_releaseopereCollectionView", ViewsGroup),
                new egafEntitiesModuleDescription("v domerisp", "v_domerispCollectionView", ViewsGroup),
			};
        }
                	}

    public partial class egafEntitiesModuleDescription : ModuleDescription<egafEntitiesModuleDescription> {
        public egafEntitiesModuleDescription(string title, string documentType, string group, Func<egafEntitiesModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}