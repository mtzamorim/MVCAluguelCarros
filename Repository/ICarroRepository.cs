using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVeiculos.Models;

namespace SistemaVeiculos.Repository
{
    public interface ICarroRepository
    {
        CarroModel Adicionar(CarroModel carro);
        List<CarroModel> ListarCarros();
    }
}