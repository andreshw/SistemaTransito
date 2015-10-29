using SistemaTransito.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTransito.Dominio.Entidades
{
    public class Propietario
    {
        public Guid Id { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public Sexo Sexo { get; set; }

        public string Ciudad { get; set; }

        public virtual List<Vehiculo> Vehiculos { get; set; }
    }
}
