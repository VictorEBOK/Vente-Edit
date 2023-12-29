
using System;
using System.ComponentModel.DataAnnotations;
using VikShop.Controllers;
namespace VikShop.Models;
public class VenteEditViewModel



{
    public int Id { get; set; }
    [StringLength(8, ErrorMessage = "Le n° la reffence de l'article doit faire entre 4 et 8 caracteres maximum,", MinimumLength = 4)]

    public string SampleNumber { get; set; }
    public DateTime SamplingDate { get; set; }
    public string NomDuVendeur { get; set; }
    public string Categorie {get; set;}
    public string Model { get; set; }
    public string Prix { get; set; }
    public string Commentaire { get; set; }

    
}

