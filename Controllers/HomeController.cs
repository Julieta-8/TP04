using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Actividad4.Models;

namespace Actividad4.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Palabra()
    {
      palabra=Resultado();
      intentos=intentos;
      
        return View("Ahorcado");
    }
    public IActionResult IngresoLetra(char letra)
    {
      Palabra.IngresoLetra(letra);
        return View("Ahorcado");
    }
 public IActionResult IngresoPalabra(string palabra)
    {
        if(palabra.Length != 0){
            Palabra.IngresoPalabra(palabra);
        }
      
        return View("Ahorcado");
    }
}
