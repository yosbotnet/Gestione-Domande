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
    /// Represents the single risposte object view model.
    /// </summary>
    public partial class risposteViewModel : SingleObjectViewModel<risposte, int, IegafEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of risposteViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static risposteViewModel Create(IUnitOfWorkFactory<IegafEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new risposteViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the risposteViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the risposteViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected risposteViewModel(IUnitOfWorkFactory<IegafEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.risposte, x => x.RI_TESTOORDINE) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of domande for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<domande> LookUpdomande {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (risposteViewModel x) => x.LookUpdomande,
                    getRepositoryFunc: x => x.domande);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of tipocommissione for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<tipocommissione> LookUptipocommissione {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (risposteViewModel x) => x.LookUptipocommissione,
                    getRepositoryFunc: x => x.tipocommissione);
            }
        }

    }
}
