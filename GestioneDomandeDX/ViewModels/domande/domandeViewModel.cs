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
    /// Represents the single domande object view model.
    /// </summary>
    public partial class domandeViewModel : SingleObjectViewModel<domande, int, IegafEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of domandeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static domandeViewModel Create(IUnitOfWorkFactory<IegafEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new domandeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the domandeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the domandeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected domandeViewModel(IUnitOfWorkFactory<IegafEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.domande, x => x.DO_TESTO) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of tipocommissione for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<tipocommissione> LookUptipocommissione {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (domandeViewModel x) => x.LookUptipocommissione,
                    getRepositoryFunc: x => x.tipocommissione);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of esami for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<esami> LookUpesami {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (domandeViewModel x) => x.LookUpesami,
                    getRepositoryFunc: x => x.esami);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of risposte for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<risposte> LookUprisposte {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (domandeViewModel x) => x.LookUprisposte,
                    getRepositoryFunc: x => x.risposte);
            }
        }


        /// <summary>
        /// The view model for the domanderisposte detail collection.
        /// </summary>
        public CollectionViewModelBase<risposte, risposte, int, IegafEntitiesUnitOfWork> domanderisposteDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (domandeViewModel x) => x.domanderisposteDetails,
                    getRepositoryFunc: x => x.risposte,
                    foreignKeyExpression: x => x.RI_DO_ID,
                    navigationExpression: x => x.domande);
            }
        }
    }
}
