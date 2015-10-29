using SistemaTransito.Dominio.Entidades;
using SistemaTransito.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTransito.Repositorio
{
    public class PropietarioRepositorio : IPropietarioRepositorio
    {
        public List<Propietario> ListarPropietarios()
        {
            using (SistemaTransitoDB contexto = new SistemaTransitoDB())
            {
                return contexto.Propietarios.ToList();
            }
        }

        public void CrearPropietario(Propietario propietario)
        {
            throw new NotImplementedException();
        }

        public void EditarPropietario(Propietario propietario)
        {
            throw new NotImplementedException();
        }

        public Propietario ConsultarPropietarioPorCedula(string numeroCedula)
        {
            throw new NotImplementedException();
        }
    }
}
