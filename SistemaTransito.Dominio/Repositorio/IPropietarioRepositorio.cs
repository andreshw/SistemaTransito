using SistemaTransito.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTransito.Dominio.Repositorio
{
    public interface IPropietarioRepositorio
    {
        List<Propietario> ListarPropietarios();

        void CrearPropietario(Propietario propietario);

        void EditarPropietario(Propietario propietario);

        Propietario ConsultarPropietarioPorCedula(string numeroCedula);
    }
}
