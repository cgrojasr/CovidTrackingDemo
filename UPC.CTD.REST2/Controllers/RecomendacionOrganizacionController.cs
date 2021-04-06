using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UPC.CTD.BL.BusinessLogic;
using UPC.CTD.REST2.Models;

namespace UPC.CTD.REST2.Controllers
{
    [RoutePrefix("api/RecOrg")]
    public class RecomendacionOrganizacionController : ApiController
    {
        private readonly RecomendacionOrganizacionBL objRecomendacionOrganizacionBL;
        public RecomendacionOrganizacionController()
        {
            objRecomendacionOrganizacionBL = new RecomendacionOrganizacionBL();
        }

        [HttpGet]
        [Route("Listar")]
        public IHttpActionResult ListarRecomendacion()
        {
            var recomendaciones = objRecomendacionOrganizacionBL.ListarRecomendacion();

            var response = from r in recomendaciones
                           select new RecomendazionOrganizacion()
                           {
                               Id = r.Id,
                               IdOrganizacion = r.IdOrganizacion,
                               Recomendacion = r.Recomendacion,
                               Activo = r.Activo
                           };

            return Ok(response);
        }

        [HttpPost]
        [Route("Registrar")]
        public IHttpActionResult Registrar([FromBody] RecomendazionOrganizacion objRecomendacionOrganizacion)
        {
            var request = new BL.RecomendacionOrganizacion() { 
                Id = objRecomendacionOrganizacion.Id,
                IdOrganizacion = objRecomendacionOrganizacion.IdOrganizacion,
                Recomendacion = objRecomendacionOrganizacion.Recomendacion,
                Activo = objRecomendacionOrganizacion.Activo
            };

            return Ok(objRecomendacionOrganizacionBL.Registrar(request));
        }

        [HttpGet]
        [Route("Buscar/{Id}")]
        public IHttpActionResult Buscar(int Id)
        {
            var recomendacion = objRecomendacionOrganizacionBL.Buscar(Id);

            var response = new RecomendazionOrganizacion() {
                Id = recomendacion.Id,
                IdOrganizacion = recomendacion.IdOrganizacion,
                Recomendacion = recomendacion.Recomendacion,
                Activo = recomendacion.Activo
            };

            return Ok(response);
        }

        [HttpGet]
        [Route("Buscar2/{Id}")]
        public IHttpActionResult Buscar2(int Id)
        {
            var recomendacion = objRecomendacionOrganizacionBL.Buscar(Id);

            var response = new RecomendazionOrganizacion()
            {
                Id = recomendacion.Id,
                IdOrganizacion = recomendacion.IdOrganizacion,
                Recomendacion = recomendacion.Recomendacion,
                Activo = recomendacion.Activo
            };

            return Ok(response);
        }
    }
}
