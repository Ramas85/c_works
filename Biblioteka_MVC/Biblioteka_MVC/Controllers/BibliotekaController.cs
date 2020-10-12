using Biblioteka_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Biblioteka_MVC.Controllers
{
    public class BibliotekaController : Controller
    {
        public IActionResult Index()
        {

            IList<Biblioteka> bibliotekaList = new List<Biblioteka>()
            {
            new Biblioteka(){Id = 1, Pavadinimas = "Kaunas", Adresas = "blabla", Miestas = "kaunas" },

            };


            return View();
        }
    }
}