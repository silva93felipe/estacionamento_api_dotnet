using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using estacionamento.context;
using estacionamento.Models;
using estacionamento.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace estacionamento.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservaController : ControllerBase
    {
        private readonly IReservaRepository _reservaRepository;

        public ReservaController(IReservaRepository reservaRepository)
        {
            _reservaRepository = reservaRepository;
        }

        [HttpDelete("{id}")]
        public IActionResult Cancelar(int id)
        {
             _reservaRepository.Delete(id);

            return NoContent();
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