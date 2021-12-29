using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvcajax.Models;

namespace mvcajax.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class LibrosController : ControllerBase
    {
        private readonly ILogger<LibrosController> _logger;

        public LibrosController(ILogger<LibrosController> logger)
        {
            _logger = logger;

        }
        [HttpGet]
        public List<Libro> Get()
        {

            LibrosRepositorio repo = new LibrosRepositorio();
            return repo.BuscarDatos();

        }
        
        [HttpPost]

        public void Insertar(Libro libro)

        {
            LibrosRepositorio repo = new LibrosRepositorio();
            repo.Insertar(libro);

        }
        [HttpDelete("{numero}")]
        public void Borrar(int numero)
        {
            LibrosRepositorio repo = new LibrosRepositorio();
            repo.Borrar(numero);

        }

        
        [HttpGet ("{numero}")]
        public Libro BuscarUno(int numero)
        {
            LibrosRepositorio repo = new LibrosRepositorio();
            return repo.BuscarUno(numero);
        }
        
    }
}

    

    
