using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UPC.CTD.BL;
using UPC.CTD.BL.BusinessLogic;

namespace UPC.CTD.REST.Controllers
{
    public class RecomendacionOrganizacionController : ApiController
    {
        private readonly RecomendacionOrganizacionBL objRecomendacionOrganizacionBL;
        public RecomendacionOrganizacionController()
        {
            objRecomendacionOrganizacionBL = new RecomendacionOrganizacionBL();
        }

        [HttpGet]
        public IHttpActionResult ListarRecomendacion() {
            return Ok(objRecomendacionOrganizacionBL.ListarRecomendacion());
        }

        [HttpPost]
        public IHttpActionResult Registrar([FromBody] RecomendacionOrganizacion objRecomendacionOrganizacion)
        {
            return Ok(objRecomendacionOrganizacionBL.Registrar(objRecomendacionOrganizacion));
        }

        [HttpGet]
        public IHttpActionResult Buscar(int Id)
        {
            return Ok(objRecomendacionOrganizacionBL.Buscar(Id));
        }

        [HttpGet]
        [Route("Buscar2/{id}")]
        public IHttpActionResult Buscar2(int Id)
        {
            return Ok(objRecomendacionOrganizacionBL.Buscar(Id));
        }
    }
}
