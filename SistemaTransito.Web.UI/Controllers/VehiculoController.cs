using EasyHttp.Http;
using SistemaTransito.Dominio.Entidades;
using SistemaTransito.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaTransito.Web.UI.Controllers
{
    public class VehiculoController : Controller
    {
        public ActionResult ListarVehiculos()
        {
            VehiculoRepositorio repositorio = new VehiculoRepositorio();
            List<Vehiculo> vehiculos = repositorio.ConsultarVehiculos();
            HttpClient cliente = new HttpClient();
            //EasyHttp.Http.HttpResponse respuesta = cliente.Get("http://localhost:49671/api/vehiculo/ObtenerVehiculos");
            //var vehiculos = respuesta.StaticBody<Vehiculo[]>();
            return View(vehiculos);
        }

        public ContentResult BuscarVehiculosPorPlaca(string placa)
        {
            VehiculoRepositorio repositorio = new VehiculoRepositorio();
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            if (!string.IsNullOrEmpty(placa))
            {
                vehiculos = repositorio.ConsultarVehiculosPorPlaca(placa);
            }
            return Content(Newtonsoft.Json.JsonConvert.SerializeObject(vehiculos));
            //return View(vehiculos);
        }

        [HttpGet]
        public ActionResult GuardarVehiculo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GuardarVehiculo(Vehiculo vehiculo)
        {
            VehiculoRepositorio repositorio = new VehiculoRepositorio();
            vehiculo.Id = Guid.NewGuid();
            repositorio.GuardarVehiculo(vehiculo);
            Session["VehiculoGuardado"] = vehiculo;
            return RedirectToAction("ListarVehiculos");
        }

        public ActionResult DetallarVehiculo(string placa)
        {
            VehiculoRepositorio repositorio = new VehiculoRepositorio();
            Vehiculo vehiculo = repositorio.ConsultarVehiculoPorPlaca(placa);
            return View(vehiculo);
        }

        [HttpGet]
        public ActionResult EditarVehiculo(Guid id)
        {
            VehiculoRepositorio repositorio = new VehiculoRepositorio();
            Vehiculo vehiculo = repositorio.ConsultarVehiculoPorId(id);
            return View(vehiculo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarVehiculo(Vehiculo vehiculo)
        {
            VehiculoRepositorio repositorio = new VehiculoRepositorio();
            repositorio.EditarVehiculo(vehiculo);
            return RedirectToAction("ListarVehiculos");
        }

        [HttpGet]
        public bool ValidarVehiculoPorPlaca(string placa)
        {
            VehiculoRepositorio repositorio = new VehiculoRepositorio();
            return repositorio.ValidarVehiculoPorPlaca(placa);
        }
	}
}