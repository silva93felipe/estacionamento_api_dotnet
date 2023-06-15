using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using estacionamento.context;
using estacionamento.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using estacionamento.Repositories;

namespace estacionamento.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstacionamentoController : ControllerBase
    {
        private readonly EstacionamentoRepository _estacionamentoRepository;

        public EstacionamentoController(EstacionamentoRepository estacionamentoRepository){
            _estacionamentoRepository = estacionamentoRepository;
        }
        
        [HttpPost]
        public async Task<IActionResult> Cadastrar(int estacionamento)
        {
            return BadRequest();
        }

    }
}