using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly ILogger<EventoController> _logger;

        /*public IEnumerable<Evento> _evento = new Evento[]{
               new Evento() {
               EventoId = 1,
               Tema = "Angular 11 e .NET 5",
               Local = "Belo Horizonte",
               Lote = "1º Lote",
               QtdPessoas = 250,
               DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
               ImagemURL = "foto.jpg"
           },
           new Evento() {
               EventoId = 2,
               Tema = "Java",
               Local = "Belo Horizonte",
               Lote = "2º Lote",
               QtdPessoas = 250,
               DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
               ImagemURL = "foto.jpg"
           }

           };*/
        private readonly DataContext context;

        public EventoController(DataContext context)
        {
            this.context = context;

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return context.Eventos;

        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return context.Eventos.FirstOrDefault(
               x => x.EventoId == id
               );

        }


        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de put id = {id}";
        }


        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de delete id = {id}";
        }
    }
}
