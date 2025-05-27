using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Actividad4.Models;

namespace Actividad4.Controllers;

public class HomeController : Controller
{
  public IActionResult Inicio()
  {

    Palabra Juego = new Palabra();
    HttpContext.Session.SetString("Juego", Objeto.ObjectToString(Juego));

    return View("Ingreso");
  }
public IActionResult Objeto() {
}

  public IActionResult Ahorcado()
  {
    
    Palabra Juego = // Levantar de Session el objeto
    ViewBag.palabra = Palabra.Resultado();
    ViewBag.intentos = Palabra.intentos;
    ViewBag.LetrasIntentadas = Palabra.LetrasIntentadas;
    ViewBag.Terminado = Palabra.Terminado;
    ViewBag.Perdiste = Palabra.Perdiste;

    return View("Ahorcado");
  }
  public IActionResult IngresoLetra2(char letra)
  {

    Palabra.IngresoLetra(letra);
    ViewBag.palabra = Palabra.Resultado();
    ViewBag.intentos = Palabra.intentos;
    ViewBag.LetrasIntentadas = Palabra.LetrasIntentadas;
    return View("Ahorcado");
  }
  public IActionResult IngresoPalabra2(string palabra2)
  {
    if (palabra2.Length != 0)
    {
      Palabra.IngresoPalabra(palabra2);
    }
    ViewBag.palabra = Palabra.Resultado();
    ViewBag.intentos = Palabra.intentos;
    ViewBag.LetrasIntentadas = Palabra.LetrasIntentadas;
    ViewBag.Terminado = Palabra.Terminado;
    ViewBag.Perdiste = Palabra.Perdiste;
    if(Palabra.Terminado==true|| Palabra.Perdiste==true){
 return View("Final");
    } else{
    return View("Ahorcado");
    }
  }

   
}
