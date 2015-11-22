using SistemaTransito.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTransito.Repositorio
{
    public class SistemaTransitoDB : DbContext
    {
        public SistemaTransitoDB()
            : base("DefaultConnection")
        {
        }

        public DbSet<Vehiculo> Vehiculos { get; set; }

        public DbSet<Propietario> Propietarios { get; set; }
    }
}
