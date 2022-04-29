using Microsoft.AspNetCore.Mvc;
using MVCCochesAwsAurora.Models;
using MVCCochesAwsAurora.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCochesAwsAurora.Controllers
{
    public class CochesController : Controller
    {
        private RepositoryCoches repo;

        public CochesController(RepositoryCoches repo)
        {
            this.repo = repo;
        }
        public IActionResult IndexCoches()
        {
            List<Coche> coches = this.repo.GetAllCoches();
            return View(coches);
        }

        public IActionResult CreateCoche()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCoche(Coche coche)
        {
            this.repo.InsertCoche(coche);
            return RedirectToAction("IndexCoches");
        }
    }
}
