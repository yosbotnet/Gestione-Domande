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
    /// Represents the releaseopere collection view model.
    /// </summary>
    public partial class releaseopereCollectionViewModel : CollectionViewModel<releaseopere, int, IegafEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of releaseopereCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static releaseopereCollectionViewModel Create(IUnitOfWorkFactory<IegafEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new releaseopereCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the releaseopereCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the releaseopereCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected releaseopereCollectionViewModel(IUnitOfWorkFactory<IegafEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.releaseopere) {
        }
    }
}