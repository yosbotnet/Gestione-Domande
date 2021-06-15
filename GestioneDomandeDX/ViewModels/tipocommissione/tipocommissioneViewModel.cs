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
    /// Represents the single tipocommissione object view model.
    /// </summary>
    public partial class tipocommissioneViewModel : SingleObjectViewModel<tipocommissione, int, IegafEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of tipocommissioneViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static tipocommissioneViewModel Create(IUnitOfWorkFactory<IegafEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new tipocommissioneViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the tipocommissioneViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the tipocommissioneViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected tipocommissioneViewModel(IUnitOfWorkFactory<IegafEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.tipocommissione, x => x.TC_ORDINAMENTOCASUALE) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of domande for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<domande> LookUpdomande {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (tipocommissioneViewModel x) => x.LookUpdomande,
                    getRepositoryFunc: x => x.domande);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of esami for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<esami> LookUpesami {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (tipocommissioneViewModel x) => x.LookUpesami,
                    getRepositoryFunc: x => x.esami);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of risposte for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<risposte> LookUprisposte {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (tipocommissioneViewModel x) => x.LookUprisposte,
                    getRepositoryFunc: x => x.risposte);
            }
        }


        /// <summary>
        /// The view model for the tipocommissionedomande detail collection.
        /// </summary>
        public CollectionViewModelBase<domande, domande, int, IegafEntitiesUnitOfWork> tipocommissionedomandeDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (tipocommissioneViewModel x) => x.tipocommissionedomandeDetails,
                    getRepositoryFunc: x => x.domande,
                    foreignKeyExpression: x => x.DO_ES_ID,
                    navigationExpression: x => x.tipocommissione);
            }
        }

        /// <summary>
        /// The view model for the tipocommissioneesami detail collection.
        /// </summary>
        public CollectionViewModelBase<esami, esami, int, IegafEntitiesUnitOfWork> tipocommissioneesamiDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (tipocommissioneViewModel x) => x.tipocommissioneesamiDetails,
                    getRepositoryFunc: x => x.esami,
                    foreignKeyExpression: x => x.ES_TC_ID,
                    navigationExpression: x => x.tipocommissione);
            }
        }

        /// <summary>
        /// The view model for the tipocommissionerisposte detail collection.
        /// </summary>
        public CollectionViewModelBase<risposte, risposte, int, IegafEntitiesUnitOfWork> tipocommissionerisposteDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (tipocommissioneViewModel x) => x.tipocommissionerisposteDetails,
                    getRepositoryFunc: x => x.risposte,
                    foreignKeyExpression: x => x.RI_ES_ID,
                    navigationExpression: x => x.tipocommissione);
            }
        }
    }
}
