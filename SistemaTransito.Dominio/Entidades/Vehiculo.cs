﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTransito.Dominio.Enumerados;

namespace SistemaTransito.Dominio.Entidades
{
    public class Vehiculo
    {
        public Guid Id { get; set; }

        public string NumeroChasis { get; set; }

        public TipoVehiculo TipoVehiculo { get; set; }

        public int Capacidad { get; set; }

        public int Cilindraje { get; set; }

        public string Placa { get; set; }

        public virtual Propietario Propietario { get; set; }
    }
}
