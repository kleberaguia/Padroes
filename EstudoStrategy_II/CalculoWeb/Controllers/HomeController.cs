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
            _
            return View();
        }
        [HttpPost]
        public ActionResult Index(IFormCollection form)
        {
            string query1 = form["txtNumero_1"];
            string query2 = form["txtNumero_2"];

            

            ViewBag.Resultado = _factory.OperacaoEscolhida(Enum.Parse<RegraNegocio_Strategy.Enum.enumOperacoes>("3"), double.Parse(query1), double.Parse(query2));
            //if (!string.IsNullOrWhiteSpace(query))
            //{
            //    //obtenha um objeto que impletemente a interface IEnumerable<SuaClass>, List<SuaClasse> por exemplo só que desssa vez filtrando, pois você tem a string query...
            //    return View();
            //}
            //else
            //{
            //    //se nada foi digitado no campo da pesquisa retorne um collection com todos os seus dados... nada vai ser filtrado.
            //    return View();
            //}

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
