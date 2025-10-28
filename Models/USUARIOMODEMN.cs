using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace proyecto_nicol.Models
{
    public class USUARIOMODEMN
    {
        public int Asuario_Id { get; set; }
        public string Usuario_Nombre { get; set; }
        public string Usuario_Apellido { get; set; }
        public string Usuario_Correo { get; set; }
        public string Usuario_Contrasena { get; set; }
    }
}