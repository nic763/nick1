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
    [Route("user")]
    public class UsuarioController : Controller
    {
        private readonly IUsuariosService usuariosService;
        public UsuarioController(IUsuariosService usuariosService)
        {
            this.usuariosService = usuariosService;
        }


        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(USUARIOMODEMN usuario)
        {
            if (ModelState.IsValid)
            {
                await usuariosService.CrearUsuario(usuario);
                return RedirectToAction("Index", "Home");

            }
            return View(usuario);

        }

        [HttpGet]
        [Route("register")]
        public IActionResult Register()
        {
            return View();

        }
    }

}