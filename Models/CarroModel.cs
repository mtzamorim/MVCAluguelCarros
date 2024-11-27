using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVeiculos.Models
{
    public class CarroModel
    {
    public int Id { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }    
    public string ImagemUrl { get; set; } // URL da imagem
    public string Status { get; set; }
    public string Placa { get; set; }
    }

    
}