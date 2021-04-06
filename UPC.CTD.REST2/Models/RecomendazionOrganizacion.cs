using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UPC.CTD.REST2.Models
{
    public class RecomendazionOrganizacion
    {
        public int Id { get; set; }
        public int IdOrganizacion { get; set; }
        public string Recomendacion { get; set; }
        public bool Activo { get; set; }
    }
}