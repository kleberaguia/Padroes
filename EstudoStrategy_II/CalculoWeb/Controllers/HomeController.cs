using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CalculoWeb.Models;
using Microsoft.AspNetCore.Http;
using RegraNegocio_Strategy.Factory;

namespace CalculoWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CalcularFactory _factory = new CalcularFactory();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
           
        }

        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(IFormCollection form)
        {
            string query1 = form["txtNumero_1"];
            string query2 = form["txtNumero_2"];
            string query3 = form["operacao"];

            

            ViewBag.Resultado = _factory.OperacaoEscolhida(Enum.Parse<RegraNegocio_Strategy.Enum.enumOperacoes>(query3), double.Parse(query1), double.Parse(query2));
            

            return View();
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
