using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using proyecto_nicol.Data;
using proyecto_nicol.Models;
using proyecto_nicol.Services;

namespace proyecto_nicol.Implementacion
{
    public class UsuarioService : IUsuariosService
    {
        
        public async Task CrearUsuario(USUARIOMODEMN usuario)
        {

            if (usuario != null)
            {
                usuario.Usuario_Contrasena = passwordServicio.HashPassword(usuario.Usuario_Contrasena);
                dBContext.Usuarios.Add(usuario);
                await dBContext.SaveChangesAsync();
            }
        }
        private readonly DBContext dBContext;
        private readonly IPasswordServicio passwordServicio;
        public UsuarioService(DBContext dBContext, IPasswordServicio passwordServicio)

        {
            this.dBContext = dBContext;
            this.passwordServicio = passwordServicio;
        }
    }
}