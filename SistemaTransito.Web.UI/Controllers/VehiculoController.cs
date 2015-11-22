using SistemaTransito.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaTransito.Web.UI.Controllers
{
    public class VehiculoController : Controller
    {
        // GET: Vehiculo
        public ActionResult ListarVehiculos()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>
            {
                new Vehiculo{ Capacidad = 3, Cilindraje=1400, Id = Guid.NewGuid(), NumeroChasis = "9tdddpo00", Placa="abc123" },
                new Vehiculo{ Capacidad = 3, Cilindraje=1400, Id = Guid.NewGuid(), NumeroChasis = "9tdddpo00", Placa="abc123" },
                new Vehiculo{ Capacidad = 3, Cilindraje=1400, Id = Guid.NewGuid(), NumeroChasis = "9tdddpo00", Placa="abc123" },
            };
            return View(vehiculos);
        }

        public ActionResult BuscarVehiculo()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>
            {
                new Vehiculo{ Capacidad = 3, Cilindraje=1400, Id = Guid.NewGuid(), NumeroChasis = "9tdddpo00", Placa="abc123" },
                new Vehiculo{ Capacidad = 3, Cilindraje=1400, Id = Guid.NewGuid(), NumeroChasis = "9tdddpo00", Placa="abc123" },
                new Vehiculo{ Capacidad = 3, Cilindraje=1400, Id = Guid.NewGuid(), NumeroChasis = "9tdddpo00", Placa="abc123" },
            };
            return View(vehiculos);
        }
    }
}