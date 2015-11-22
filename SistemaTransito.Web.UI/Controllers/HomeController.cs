using SistemaTransito.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaTransito.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["VehiculoGuardado"] != null)
            {
                Vehiculo vehiculo = (Vehiculo)Session["VehiculoGuardado"];
                ViewBag.MensajeVehiculo = "Ultima placa de vehiculo creado:" + vehiculo.Placa;
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}