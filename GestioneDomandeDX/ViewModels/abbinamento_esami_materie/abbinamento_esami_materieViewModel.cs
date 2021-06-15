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
    /// Represents the single abbinamento_esami_materie object view model.
    /// </summary>
    public partial class abbinamento_esami_materieViewModel : SingleObjectViewModel<abbinamento_esami_materie, int, IegafEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of abbinamento_esami_materieViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static abbinamento_esami_materieViewModel Create(IUnitOfWorkFactory<IegafEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new abbinamento_esami_materieViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the abbinamento_esami_materieViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the abbinamento_esami_materieViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected abbinamento_esami_materieViewModel(IUnitOfWorkFactory<IegafEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.abbinamento_esami_materie, x => x.AB5_RELEASE) {
                }



    }
}
