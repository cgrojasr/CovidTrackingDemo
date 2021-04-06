using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using UPC.CTD.BL.BusinessLogic;

namespace UPC.CTD.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RecomendacionOrganizacionSVC" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RecomendacionOrganizacionSVC.svc or RecomendacionOrganizacionSVC.svc.cs at the Solution Explorer and start debugging.
    public class RecomendacionOrganizacionSVC : IRecomendacionOrganizacionSVC
    {
        private readonly RecomendacionOrganizacionBL objRecomendacionOrganizacionBL;

        public RecomendacionOrganizacionSVC()
        {
            objRecomendacionOrganizacionBL = new RecomendacionOrganizacionBL();
        }
        public List<RecomendacionOrganizacion> ListarRecomendacion()
        {
            var query = objRecomendacionOrganizacionBL.ListarRecomendacion();

            var response = from recomendacion in query
                           select new RecomendacionOrganizacion
                           {
                               Id = recomendacion.Id,
                               Recomendacion = recomendacion.Recomendacion,
                               IdOrganizacion = recomendacion.IdOrganizacion,
                               Activo = recomendacion.Activo
                           };

            return response.ToList();
        }

        public int Registrar(RecomendacionOrganizacion recomendacion)
        {
            var request = new BL.RecomendacionOrganizacion() { 
                Id = recomendacion.Id,
                IdOrganizacion = recomendacion.IdOrganizacion,
                Recomendacion = recomendacion.Recomendacion,
                Activo = recomendacion.Activo
            };
            return objRecomendacionOrganizacionBL.Registrar(request);
        }
    }
}
