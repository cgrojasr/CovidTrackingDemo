using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using UPC.CTD.BL;
using UPC.CTD.BL.BusinessLogic;

namespace UPC.CTD.UT
{
    [TestClass]
    public class RecomendacionOrganizacionUT
    {
        RecomendacionOrganizacionBL objROBL;
        public RecomendacionOrganizacionUT()
        {
            objROBL = new RecomendacionOrganizacionBL();
        }

        [TestMethod]
        public void Registro()
        {
            RecomendacionOrganizacion objeto = new RecomendacionOrganizacion();
            objeto.IdOrganizacion = 1;
            objeto.Recomendacion = "Prueba de recomendación";
            objeto.Activo = true;

            var id = objROBL.Registrar(objeto);

            Assert.AreEqual(3, id);
        }

        [TestMethod]
        public void Listar()
        {
            var cantidad = objROBL.ListarRecomendacion().Count();

            Assert.AreEqual(0, cantidad);
        }

        [TestMethod]
        public void Actualizar()
        {
            RecomendacionOrganizacion objeto = new RecomendacionOrganizacion();
            objeto.Id = 1;
            objeto.IdOrganizacion = 1;
            objeto.Recomendacion = "Prueba de recomendación actualizada";
            objeto.Activo = false;

            var respuesta = objROBL.Actualizar(objeto);

            Assert.AreEqual(true, respuesta);
        }

        [TestMethod]
        public void Eliminar()
        {
            var respuesta = objROBL.Eliminar(1);

            Assert.AreEqual(true, respuesta);
        }
    }
}
