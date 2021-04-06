using System.Collections.Generic;
using UPC.CTD.BL.DataAccess;

namespace UPC.CTD.BL.BusinessLogic
{
    public class RecomendacionOrganizacionBL
    {
        RecomendacionOrganizacionDA objRecomendacionOrganizacionDA;
        public RecomendacionOrganizacionBL()
        {
            objRecomendacionOrganizacionDA = new RecomendacionOrganizacionDA();
        }

        public RecomendacionOrganizacion Buscar(int Id)
        {
            return objRecomendacionOrganizacionDA.Buscar(Id);
        }
        public List<RecomendacionOrganizacion> ListarRecomendacion() {
            return objRecomendacionOrganizacionDA.ListarRecomendacion();
        }

        public int Registrar(RecomendacionOrganizacion objRecomendacionOrganizacion)
        {
            try
            {
                return objRecomendacionOrganizacionDA.Registrar(objRecomendacionOrganizacion);
            }
            catch (System.Exception)
            {
                return -1;
            }
        }

        public bool Actualizar(RecomendacionOrganizacion objRecomendacionOrganizacion)
        {
            return objRecomendacionOrganizacionDA.Actualizar(objRecomendacionOrganizacion);
        }

        public bool Eliminar(int Id)
        {
            return objRecomendacionOrganizacionDA.Eliminar(Id);
        }
    }
}
