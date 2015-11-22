using SistemaTransito.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTransito.Repositorio
{
    public class VehiculoRepositorio
    {
        public void GuardarVehiculo(Vehiculo vehiculo)
        {
            using (SistemaTransitoDB contexto = new SistemaTransitoDB())
            {
                contexto.Vehiculos.Add(vehiculo);
                contexto.SaveChanges();
            }
        }

        public List<Vehiculo> ConsultarVehiculos()
        { 
            using(SistemaTransitoDB contexto = new SistemaTransitoDB())
            {
                return contexto.Vehiculos.ToList();
            }
        }

        public List<Vehiculo> ConsultarVehiculosPorPlaca(string placa)
        {
            using (SistemaTransitoDB contexto = new SistemaTransitoDB())
            {
                return contexto.Vehiculos.Where(v => v.Placa.Contains(placa)).ToList();
            }
        }

        public Vehiculo ConsultarVehiculoPorPlaca(string placa)
        {
            using (SistemaTransitoDB contexto = new SistemaTransitoDB())
            {
                return contexto.Vehiculos.FirstOrDefault(v => v.Placa == placa);
            }
        }

        public Vehiculo ConsultarVehiculoPorId(Guid id)
        {
            using (SistemaTransitoDB contexto = new SistemaTransitoDB())
            {
                return contexto.Vehiculos.FirstOrDefault(v => v.Id == id);
            }
        }

        public void EditarVehiculo(Vehiculo vehiculo)
        {
            using (SistemaTransitoDB contexto = new SistemaTransitoDB())
            {
                Vehiculo vehiculoEditado = contexto.Vehiculos.FirstOrDefault(v => v.Id == vehiculo.Id);
                vehiculoEditado.Capacidad = vehiculo.Capacidad;
                vehiculoEditado.Cilindraje = vehiculo.Cilindraje;
                vehiculoEditado.NumeroChasis= vehiculo.NumeroChasis;
                vehiculoEditado.Placa = vehiculo.Placa;
                contexto.SaveChanges();
                
            }
        }

        public bool ValidarVehiculoPorPlaca(string placa)
        {
            using (SistemaTransitoDB contexto = new SistemaTransitoDB())
            {
                return contexto.Vehiculos.FirstOrDefault(v => v.Placa == placa) == null;
            }
        }
    }
}
