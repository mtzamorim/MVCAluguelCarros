using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaVeiculos.Models;

namespace SistemaVeiculos.Data
{
    public class AluguelContext(DbContextOptions<AluguelContext> options) : DbContext (options)
    {
        public DbSet<CarroModel> Carros { get; set; }
        public DbSet<ReservaModel> Reservas { get; set; }
    }
}