using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GestionCrytpo.Models;
using GestionCrytpo.Services.Interface;
using GestionCrytpo.Factory.Interface;

namespace GestionCrytpo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private List<CryptoCurrencyModel> cryptoCurrencyModels;
        private ICryptoCurrencyModelFactory _cryptoCurrencyModelFactory;
        private IObtenirPrixCrypto _obtenirPrixCrypto { get; }

        public HomeController(ILogger<HomeController> logger, IObtenirPrixCrypto obtenirPrixCrypto, ICryptoCurrencyModelFactory cryptoCurrencyModelFactory)
        {
            _logger = logger;
            _obtenirPrixCrypto = obtenirPrixCrypto;
            _cryptoCurrencyModelFactory = cryptoCurrencyModelFactory;
        }

        public IActionResult Index()
        {
            Task<string> prixCrypto = _obtenirPrixCrypto.GetPrixCryptos();
            CryptoCurrencyModel crytpoModel = _cryptoCurrencyModelFactory.CreateCryptoCurrencyModelObject(prixCrypto.Result);
            cryptoCurrencyModels.Add(crytpoModel);
            return View(crytpoModel);
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
