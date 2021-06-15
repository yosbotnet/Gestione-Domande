using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using GestioneDomandeDX.egafEntitiesDataModel;
using GestioneDomandeDX.Common;
using GestioneDomandeDX;

namespace GestioneDomandeDX.ViewModels {

    /// <summary>
    /// Represents the abbinamento_esami_materie collection view model.
    /// </summary>
    public partial class abbinamento_esami_materieCollectionViewModel : CollectionViewModel<abbinamento_esami_materie, int, IegafEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of abbinamento_esami_materieCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static abbinamento_esami_materieCollectionViewModel Create(IUnitOfWorkFactory<IegafEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new abbinamento_esami_materieCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the abbinamento_esami_materieCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the abbinamento_esami_materieCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected abbinamento_esami_materieCollectionViewModel(IUnitOfWorkFactory<IegafEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.abbinamento_esami_materie) {
        }
    }
}