using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace proyecto_nicol.Models
{
    public class USUARIOMODEMN
    {
        public int Asuario_Id { get; set; }
        [Required(ErrorMessage = "El Nombre es obligatorio.")]
        public required string Usuario_Nombre { get; set; }
        [Required(ErrorMessage = "El Nombre es obligatorio.")]
        public required string Usuario_Apellido { get; set; }
       [Required(ErrorMessage = "El Correo es obligatorio.")]
        public required string Usuario_Correo { get; set; }
        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [MinLength(6, ErrorMessage = " La Contraseña debe tener al menos 6 caractere.")] 
        public required string Usuario_Contrasena { get; set; }
    }
}