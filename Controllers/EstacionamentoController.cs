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
        public IActionResult Create(Estacionamento estacionamento)
        {
            _estacionamentoRepository.Create(estacionamento);
            return Ok(estacionamento);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var estacionamentos = _estacionamentoRepository.GetAll();
            return Ok(estacionamentos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var estacionamento = _estacionamentoRepository.GetById(id);
            if(estacionamento is null ){
                return BadRequest();
            }
            return Ok(estacionamento);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _estacionamentoRepository.Delete(id);

            return NoContent();
        }


        [HttpPatch("{id}")]
        public IActionResult AtualizarCapacidade(int id, Estacionamento estacionamento )
        {
            _estacionamentoRepository.Update(id, estacionamento);
            return NoContent();
        }

    }
}