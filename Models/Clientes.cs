using System;
using System.Collections.Generic;

namespace ClientesAPI.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Estado { get; set; }

        public ICollection<InformacionCliente> InformacionClientes { get; set; }
    }
}
