using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using GestioneDomandeDX.egafEntitiesDataModel;
using GestioneDomandeDX.Common;
using GestioneDomandeDX;

namespace GestioneDomandeDX.ViewModels {

    /// <summary>
    /// Represents the single dettaglioregole object view model.
    /// </summary>
    public partial class dettaglioregoleViewModel : SingleObjectViewModel<dettaglioregole, Tuple<int, int>, IegafEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of dettaglioregoleViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static dettaglioregoleViewModel Create(IUnitOfWorkFactory<IegafEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new dettaglioregoleViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the dettaglioregoleViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the dettaglioregoleViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected dettaglioregoleViewModel(IUnitOfWorkFactory<IegafEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.dettaglioregole, x => x.DR_DESCRIZIONE) {
                }



    }
}
