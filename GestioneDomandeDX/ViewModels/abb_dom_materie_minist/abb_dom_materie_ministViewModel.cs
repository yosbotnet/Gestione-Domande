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
    /// Represents the single abb_dom_materie_minist object view model.
    /// </summary>
    public partial class abb_dom_materie_ministViewModel : SingleObjectViewModel<abb_dom_materie_minist, int, IegafEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of abb_dom_materie_ministViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static abb_dom_materie_ministViewModel Create(IUnitOfWorkFactory<IegafEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new abb_dom_materie_ministViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the abb_dom_materie_ministViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the abb_dom_materie_ministViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected abb_dom_materie_ministViewModel(IUnitOfWorkFactory<IegafEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.abb_dom_materie_minist, x => x.AB9_RELEASE) {
                }



    }
}
