using SistemaTransito.Dominio.Entidades;
using SistemaTransito.Repositorio;
using SistemaTransito.Web.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SistemaTransito.Web.API.Controllers
{
    public class VehiculoController : ApiController
    {
        [HttpGet]
        public List<VehiculoComposite> ObtenerVehiculos()
        {
            VehiculoRepositorio repositorio = new VehiculoRepositorio();
            List<Vehiculo> vehiculos = repositorio.ConsultarVehiculos();
            //return vehiculos;
            return this.ConvertirVehiculo(vehiculos);
        }

        private List<VehiculoComposite> ConvertirVehiculo(List<Vehiculo> vehiculos)
        {
            List<VehiculoComposite> vehiculosComposite = new List<VehiculoComposite>();

            foreach (Vehiculo vehiculo in vehiculos)
            {
                vehiculosComposite.Add(new VehiculoComposite
                    {
                        //Id = vehiculo.Id,
                        Placa = vehiculo.Placa,
                        //TipoVehiculo = 0,
                        //Capacidad = vehiculo.Capacidad,
                        //Cilindraje = vehiculo.Cilindraje
                    });
            }

            return vehiculosComposite;
        }

        [HttpPost]
        public string GuardarVehiculo(Vehiculo vehiculo)
        {
            VehiculoRepositorio repositorio = new VehiculoRepositorio();
            repositorio.GuardarVehiculo(vehiculo);
            return "Vehiculo almacenado";
        }
    }
}
