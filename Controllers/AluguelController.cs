using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaVeiculos.Models;
using SistemaVeiculos.Repository;

namespace SistemaVeiculos.Controllers
{
    public class AluguelController : Controller
    {
        private readonly ICarroRepository _carroRepository;
        public AluguelController(ICarroRepository carroRepository){
            _carroRepository = carroRepository;
        }
        public IActionResult Index()
        {
            var carro = _carroRepository.ListarCarros();
            return View(carro);
        }

        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(CarroModel carro)
        {
            _carroRepository.Adicionar(carro);
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}