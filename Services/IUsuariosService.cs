using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proyecto_nicol.Models;

namespace proyecto_nicol.Services
{
    public interface IUsuariosService
    {
        void CrearUsuario(USUARIOMODEMN usuario);
    }
}