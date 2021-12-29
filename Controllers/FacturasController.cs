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
     
        public class FacturasController : ControllerBase
    {

        private readonly ILogger<FacturasController> _logger;

        public FacturasController(ILogger<FacturasController> logger)
        {
            _logger = logger;

        }
        [HttpGet]
        public List<Factura> Get()
        {

            FacturaRepositorio repo = new FacturaRepositorio();
            return repo.BuscarDatos();

        }

        [HttpPost]

        public void Insertar(Factura factura)

        {
            FacturaRepositorio repo = new FacturaRepositorio();
            repo.Insertar(factura);

        }
        [HttpDelete("{numero:int}")]
        public void Borrar(int Numero)
        {
            FacturaRepositorio repo = new FacturaRepositorio();
            repo.Borrar(Numero);

        }
        [HttpGet ("{numero:int}")]
        
            public Factura BuscarUno(int numero)
        {
            FacturaRepositorio repo = new FacturaRepositorio();
            return repo.BuscarUno(numero);
        }

        [HttpPut("{numero:int}")]

            public void Salvar (int numero, Factura factura)
            {   
                Console.WriteLine(numero);
                Console.WriteLine(factura.Numero);

                
                
                FacturaRepositorio repo= new FacturaRepositorio();
                repo.Salvar(factura);
                }
    }
}

