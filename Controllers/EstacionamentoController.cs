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
    public class EstacionamentoController : ControllerBase
    {
        private readonly IEstacionamentoRepository _estacionamentoRepository;

        public EstacionamentoController(IEstacionamentoRepository estacionamentoRepository){
            _estacionamentoRepository = estacionamentoRepository;
        }
        
        [HttpPost]
        public IActionResult Cadastrar(Estacionamento estacionamento)
        {
            _estacionamentoRepository.Create(estacionamento);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var estacionamentos = _estacionamentoRepository.GetAll();
            return Ok(estacionamentos);
        }

    }
}