using System;
using System.Collections.Generic;

#nullable disable

namespace Muro.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }

        public DateTime Cumpleanos { get; set; }
        public DateTime? Registro { get; set; }

        public double edad()
        {
            double edad = 0;

            edad = (DateTime.Now - Cumpleanos).TotalDays/365;
            
            return edad;
        }

    }
}
