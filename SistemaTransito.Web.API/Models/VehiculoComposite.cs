using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaTransito.Web.API.Models
{
    public class VehiculoComposite
    {
        [JsonProperty("CodigoSecretoDeVehiculo")]
        public string Placa { get; set; }
    }
}