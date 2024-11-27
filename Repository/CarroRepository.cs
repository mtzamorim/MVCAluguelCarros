using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVeiculos.Data;
using SistemaVeiculos.Models;

namespace SistemaVeiculos.Repository
{
    public class CarroRepository : ICarroRepository
    {
        private readonly AluguelContext _aluguelContext;
        public CarroRepository(AluguelContext aluguelContext){
            _aluguelContext = aluguelContext;
        }
        public CarroModel Adicionar(CarroModel carro)
        {
            _aluguelContext.Carros.Add(carro);
            _aluguelContext.SaveChanges();
            return carro;
        }

        public List<CarroModel> ListarCarros()
        {
           return _aluguelContext.Carros.ToList();
            
        }
    }
}