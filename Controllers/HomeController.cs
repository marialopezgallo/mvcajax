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
    public class HomeController : Controller
    {
        static List<string> textos = new List<string>();

        static HomeController()
        {
            textos.Add("hola");
            textos.Add("que");
            textos.Add("tal");
            textos.Add("estas");
        }
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

        }
        public JsonResult ListaFacturasJson()

        {
            FacturaRepositorio repo = new FacturaRepositorio();
            List<Factura> lista = repo.BuscarDatos();
            return Json(lista);
        }
        
        public IActionResult InsertarJSON( [FromBody] Factura factura)
        {
            Console.WriteLine(factura.Numero);
            Console.WriteLine(factura.Concepto);
            Console.WriteLine(factura.Importe);
            FacturaRepositorio repo = new FacturaRepositorio();
            repo.Insertar(factura);
            return Json("Success");
        }

        public IActionResult Insertar(Factura factura)
        {
            FacturaRepositorio repo = new FacturaRepositorio();
            repo.Insertar(factura);
            return RedirectToAction("ListaFacturas","Home");
        }


        public IActionResult Index()
        {

            FacturaRepositorio repo = new FacturaRepositorio();
            List<Factura> listaFacturas = repo.BuscarDatos();
            ViewBag.listaFacturas = listaFacturas;

            return View();
        }



        public IActionResult ListaFacturas()
        {
            FacturaRepositorio repo = new FacturaRepositorio();
            ViewBag.listafacturas = repo.BuscarDatos();
            return View();
        }


        public IActionResult ListaLibros()
        {
            LibrosRepositorio repo = new LibrosRepositorio();
            ViewBag.listalibros = repo.BuscarDatos();
            return View();
        }

          public IActionResult ListaLibros2()
        {
            
            return View();
        }

        public JsonResult ListaLibrosJson()

        {
            LibrosRepositorio repo = new LibrosRepositorio();
            List<Libro> lista = repo.BuscarDatos();
            return Json(lista);
        }
        
        public IActionResult Insertar(Libro libro)
        {
            LibrosRepositorio repo = new LibrosRepositorio();
            repo.Insertar(libro);
            return RedirectToAction("listalibros","Home");
        }

        public IActionResult InsertarJSON( [FromBody] Libro libro)
        {
            Console.WriteLine(libro.Numero);
            Console.WriteLine(libro.Titulo);
            Console.WriteLine(libro.Autor);
            LibrosRepositorio repo = new LibrosRepositorio();
            repo.Insertar(libro);
            return Json("Success");
        }

           
        }


/*

         public IActionResult ListaPersonas()
        {
            PersonaRepositorio repo = new PersonaRepositorio();
            ViewBag.ListaPersonas = repo.BuscarTodas();
            return View();
        }

        public IActionResult ListaPersonasJSON()
        {
            PersonaRepositorio repo = new PersonaRepositorio();
            List<Persona> lista = repo.BuscarTodas();
            return Json(lista);
        }
        
        public JsonResult ListaFacturasJSONFiltro(string concepto)
        {
            FacturaRepositorio repo = new FacturaRepositorio();


            List<Factura> lista;
            if (concepto != null)
            {
                lista = repo.BuscarTodasPorConcepto(concepto);
            }
            else
            {
                lista = repo.BuscarTodas();
            }



            return Json(lista);
        }

        */


    }







