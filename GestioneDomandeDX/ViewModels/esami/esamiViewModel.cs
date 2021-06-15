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
    /// Represents the single esami object view model.
    /// </summary>
    public partial class esamiViewModel : SingleObjectViewModel<esami, int, IegafEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of esamiViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static esamiViewModel Create(IUnitOfWorkFactory<IegafEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new esamiViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the esamiViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the esamiViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected esamiViewModel(IUnitOfWorkFactory<IegafEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.esami, x => x.ES_DESCRIZIONE) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of domande for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<domande> LookUpdomande {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (esamiViewModel x) => x.LookUpdomande,
                    getRepositoryFunc: x => x.domande);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of tipocommissione for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<tipocommissione> LookUptipocommissione {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (esamiViewModel x) => x.LookUptipocommissione,
                    getRepositoryFunc: x => x.tipocommissione);
            }
        }


        /// <summary>
        /// The view model for the esamidomande detail collection.
        /// </summary>
        public CollectionViewModelBase<domande, domande, int, IegafEntitiesUnitOfWork> esamidomandeDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (esamiViewModel x) => x.esamidomandeDetails,
                    getRepositoryFunc: x => x.domande,
                    foreignKeyExpression: x => x.DO_ES_ID,
                    navigationExpression: x => x.esami);
            }
        }
    }
}
