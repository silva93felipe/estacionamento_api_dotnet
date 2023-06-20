using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using estacionamento.context;
using estacionamento.Models;
using Microsoft.AspNetCore.Mvc;

namespace estacionamento.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservaController : ControllerBase
    {
        private readonly EstacionamentoContext _estacionamentoContext;

        public ReservaController(EstacionamentoContext estaciomanetoContext){
            _estacionamentoContext = estaciomanetoContext;
        }
        
        [HttpDelete]
        public async Task<IActionResult> Cancelar(int reserva)
        {

            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> Reservar(int veiculoId, int estabeleciomentoId)
        {

            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> Encerrar(int veiculoId)
        {

            return BadRequest();
        }
    }
}