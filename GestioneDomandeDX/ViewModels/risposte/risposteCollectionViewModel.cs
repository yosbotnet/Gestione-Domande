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
    /// Represents the risposte collection view model.
    /// </summary>
    public partial class risposteCollectionViewModel : CollectionViewModel<risposte, int, IegafEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of risposteCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static risposteCollectionViewModel Create(IUnitOfWorkFactory<IegafEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new risposteCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the risposteCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the risposteCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected risposteCollectionViewModel(IUnitOfWorkFactory<IegafEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.risposte) {
        }
    }
}