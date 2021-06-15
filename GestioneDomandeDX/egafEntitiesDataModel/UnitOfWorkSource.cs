using DevExpress.Mvvm;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using DevExpress.Mvvm.DataModel.EF6;
using GestioneDomandeDX;
using System;
using System.Collections;
using System.Linq;

namespace GestioneDomandeDX.egafEntitiesDataModel {

    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {

		/// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<IegafEntitiesUnitOfWork> GetUnitOfWorkFactory() {
            return new DbUnitOfWorkFactory<IegafEntitiesUnitOfWork>(() => new egafEntitiesUnitOfWork(() => new egafEntities()));
        }
    }
}