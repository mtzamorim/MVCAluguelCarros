using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVeiculos.Models
{
    public class ReservaModel
{
    public int Id { get; set; }
    public int CarroId { get; set; }
    public CarroModel Carro { get; set; }
    public string Usuario { get; set; }
    public decimal PrecoDiario { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
}
}