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
    public class ClienteController : Controller
    {
        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
        }

        public IActionResult IndexCliente()
        {
            ClienteRepository repo = new ClienteRepository();
            List<Cliente> listaclientes = repo.BuscarTodos();
            ViewBag.listaclientes = listaclientes;
            return View();
        }
        public IActionResult ListaClientesJson()

        {
            ClienteRepository repo = new ClienteRepository();
            List<Cliente> listaclientes = repo.BuscarTodos();

            return Json(listaclientes);
        }

        public IActionResult ListaClientes()

        {
            ClienteRepository repo = new ClienteRepository();
            ViewBag.listaclientes = repo.BuscarTodos();

            return View();
        }

        public IActionResult Insertar(Cliente cliente)
        { 
                  Console.WriteLine("entra insertar");

                ClienteRepository repo = new ClienteRepository();
                repo.Insertar(cliente);
                 ViewBag.listaclientes = repo.BuscarTodos();
                return View("ListaClientes");
                
        }

         public IActionResult FormularioInsertar()
        { 
                
               Console.WriteLine("entra enformularioinsertar");
                return View();
                
        }

        public IActionResult Borrar(string dni)
        {       Console.WriteLine( "entra a borrar");
                
                ClienteRepository repo= new ClienteRepository();
                repo.Borrar(dni);
                ViewBag.listaclientes = repo.BuscarTodos();
                return View("ListaClientes");
                }


        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}