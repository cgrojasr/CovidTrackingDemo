using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UPC.CTD.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRecomendacionOrganizacionSVC" in both code and config file together.
    [ServiceContract]
    public interface IRecomendacionOrganizacionSVC
    {
        [OperationContract]
        List<RecomendacionOrganizacion> ListarRecomendacion();
        [OperationContract]
        int Registrar(RecomendacionOrganizacion recomendacion);
    }

    [DataContract]
    public class RecomendacionOrganizacion {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Recomendacion { get; set; }
        [DataMember]
        public int IdOrganizacion { get; set; }
        [DataMember]
        public bool Activo { get; set; }
    }
}
