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
    /// Represents the single releaseopere object view model.
    /// </summary>
    public partial class releaseopereViewModel : SingleObjectViewModel<releaseopere, int, IegafEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of releaseopereViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static releaseopereViewModel Create(IUnitOfWorkFactory<IegafEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new releaseopereViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the releaseopereViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the releaseopereViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected releaseopereViewModel(IUnitOfWorkFactory<IegafEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.releaseopere, x => x.RO_DESCR_REL_MULTIMEDIALE) {
                }



    }
}
