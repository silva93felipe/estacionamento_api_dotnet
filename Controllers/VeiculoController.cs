using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using estacionamento.context;
using estacionamento.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using estacionamento.Repositories.Interfaces;

namespace estacionamento.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VeiculoController : ControllerBase
    {

        private readonly IVeiculoRepository _veiculoRepository;

        public VeiculoController(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        [HttpPost]
        public IActionResult Create(Veiculo veiculo)
        {
            _veiculoRepository.Create(veiculo);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var veiculos = _veiculoRepository.GetAll();
            return Ok(veiculos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var veiculo =  _veiculoRepository.GetById(id);
            if(veiculo is null){
                return NotFound();
            }

            return Ok(veiculo);
        }
    }
}