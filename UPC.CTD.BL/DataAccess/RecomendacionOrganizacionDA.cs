using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.CTD.BL.DataAccess
{
    class RecomendacionOrganizacionDA
    {

        private readonly dmCovidTrackingDataContext db;
        public RecomendacionOrganizacionDA()
        {
            db = new dmCovidTrackingDataContext();
        }

        public List<RecomendacionOrganizacion> ListarRecomendacion() {
            try
            {
                var query = from recomendacion in db.RecomendacionOrganizacions
                            where recomendacion.Activo
                            select recomendacion;

                return query.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public RecomendacionOrganizacion Buscar(int id)
        {
            var query = from recomendacion in db.RecomendacionOrganizacions
                        where recomendacion.Id.Equals(id)
                        select recomendacion;

            return query.Single();
        }

        public int Registrar(RecomendacionOrganizacion objRecomendacion) {
            db.RecomendacionOrganizacions.InsertOnSubmit(objRecomendacion);
            db.SubmitChanges();

            return objRecomendacion.Id;
        }

        public bool Actualizar(RecomendacionOrganizacion objRecomendacion)
        {
            try
            {
                var query = from recomendacion in db.RecomendacionOrganizacions
                            where recomendacion.Id.Equals(objRecomendacion.Id)
                            select recomendacion;

                var recomendacionOrganizacion = query.Single();

                recomendacionOrganizacion.Recomendacion = objRecomendacion.Recomendacion;
                recomendacionOrganizacion.IdOrganizacion = objRecomendacion.IdOrganizacion;
                recomendacionOrganizacion.Activo = objRecomendacion.Activo;

                db.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Eliminar(int Id)
        {
            try
            {
                var query = from recomendacion in db.RecomendacionOrganizacions
                            where recomendacion.Id.Equals(Id)
                            select recomendacion;

                var recomendacionOrganizacion = query.Single();

                db.RecomendacionOrganizacions.DeleteOnSubmit(recomendacionOrganizacion);
                db.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
