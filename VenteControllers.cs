using System;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VikShop.Models;

namespace VikShop.Controllers;

public class VenteController : Controller
{
    private readonly ILogger<VenteController> _logger;

    public VenteController(ILogger<VenteController> logger)
    {
        _logger = logger;
    }

  


    public IActionResult Edit(int id = -1)
    {
       
        var model = new VenteEditViewModel();

        if (id != -1)
        {
            model = new VenteEditViewModel()
            {
                SamplingDate = new DateTime(2023, 10, 30, 12, 54, 30),
                SampleNumber = "AD19888",
                NomDuVendeur = "Victor",
                Categorie = "Robe",
                Model = "Ensemble",
                Prix = "50 Euro",
                Commentaire = "je valide cette commande manuelle",
                Id = id,
            };
        }

        return View(model);
    }


    [HttpPost]
    public IActionResult Edit(VenteEditViewModel model)
    {
        return View();
    }
}

