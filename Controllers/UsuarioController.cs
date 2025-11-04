using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proyecto_nicol.Implementacion;
using proyecto_nicol.Models;
using proyecto_nicol.Services;

namespace proyecto_nicol.Controllers
{
    [Route("/user")]
    public class UsuarioController : Controller
    {
        private readonly IUsuariosService usuariosService;
        public UsuarioController(IUsuariosService usuariosService)
        {
            this.usuariosService = usuariosService;
        }


        [HttpPost]
        [Route("register")]
        public IActionResult Register(USUARIOMODEMN usuario)
        {
            if (usuario != null)
            {
                usuariosService.CrearUsuario(usuario);
                return Ok("usuario creado");
            }
            else
            {
                return BadRequest("Usuario no puede ser null");
            }

        }
    }

}   