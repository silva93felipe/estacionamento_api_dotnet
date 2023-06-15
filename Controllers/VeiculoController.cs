using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using estacionamento.context;
using estacionamento.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace estacionamento.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VeiculoController : ControllerBase
    {
        private readonly EstacionamentoContext _estacionamentoContext;

        public VeiculoController(EstacionamentoContext estaciomanetoContext){
            _estacionamentoContext = estaciomanetoContext;
        }
        
        [HttpPost]
        public async Task<IActionResult> Cadastrar(int veiculo)
        {
            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetVeiculos()
        {
            return BadRequest();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVeiculoById(int id)
        {
            return BadRequest();
        }
    }
}