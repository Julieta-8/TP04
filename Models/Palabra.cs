using System.Security.Cryptography.X509Certificates;

namespace Actividad4.Models;
 static class Palabra
{
  public static string palabra = "PROGRAMACION";

  public static bool Terminado = false;
   public static bool Perdiste = false;
    public static bool Completado = false;
   
public static int intentos = 0;
public static List< char> LetrasIntentadas = new List<char>();


public static string Resultado(){
  string resultado = " ";
    foreach (char l in palabra)
    {
      if (!LetrasIntentadas.Contains(l))
      {
        resultado += " _";
      }
      else
      {
        resultado += l;
      }
    }
    if (Terminado == true)
    {
      resultado = "GANO";
    }
if (Perdiste == true)
    {
      resultado = "PERDIO";
}
return resultado;
}
public static void IngresoPalabra(string palabra2){
  intentos++;
  if(palabra == palabra2){
      Terminado = true;
    
      
  }
  else{
      Perdiste = true;
  }
}
  public static void IngresoLetra(char letra)
  {
    if (!LetrasIntentadas.Contains(letra) && !Terminado)
    {
      intentos++;
      LetrasIntentadas.Add(letra);

      foreach (char l in palabra)
      {
        if (!LetrasIntentadas.Contains(l))
        {
          Completado = false;
        }
        //if (LetrasIntentadas.Contains('P'&'R'&'O'&'G'&'A'&'M'&'C'&'I'&'N'))
       // {
       //   Terminado = true;
      //  }
      char[] letras = { 'P', 'R', 'O', 'G', 'A', 'M', 'C', 'I', 'N' };

if (letras.All(letra => LetrasIntentadas.Contains(letra)))
{
    Terminado = true;
}
      }
    }
  }

  
}
