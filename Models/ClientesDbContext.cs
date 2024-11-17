using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ClientesAPI.Models
{
    public class ClientesContext : DbContext
    {
        public ClientesContext(DbContextOptions<ClientesContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<InformacionCliente> InformacionClientes { get; set; }
    }
}
