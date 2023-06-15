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
        
        [HttpPost]
        public async Task<IActionResult> Cadastrar(int reserva)
        {

            return BadRequest();
        }
    }
}