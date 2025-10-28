using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proyecto_nicol.Data;
using proyecto_nicol.Models;
using proyecto_nicol.Services;

namespace proyecto_nicol.Implementacion
{
    public class UsuarioService : IUsuariosService
    {
        public void CrearUsuario(USUARIOMODEMN usuario)
        {
            throw new NotImplementedException();
        }
        private readonly DBContext dBContext;
        public UsuarioService(DBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public async void CrearUsuarioAsync(USUARIOMODEMN usuario)
        {
            {
                if (usuario != null)
                    dBContext.Usuarios.Add(usuario);
                await dBContext.SaveChangesAsync();
            }

        }
    }
}