using System;

namespace ClientesAPI.Models
{
    public class InformacionCliente
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string TipoInformacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string UsuarioCreador { get; set; }
        public bool EstadoInformacion { get; set; }

        public Cliente Cliente { get; set; }
    }
}
