using System.Security.Cryptography.X509Certificates;

namespace Actividad4.Models;
  class Palabra
{
  public  string palabra = "PROGRAMACION";
  public  bool Terminado = false;
   public  bool Perdiste = false;
public  int intentos = 0;
public  List< char> LetrasIntentadas = new List<char>();


public  string Resultado(){
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
public  void IngresoPalabra(string palabra2){
  intentos++;
  if(palabra == palabra2){
      Terminado = true;  
  }
  else{
      Perdiste = true;
  }
}
  public  void IngresoLetra(char letra)
  {
    if (!LetrasIntentadas.Contains(letra) && !Terminado)
    {
      intentos++;
      LetrasIntentadas.Add(letra);

      
       
      char[] letras = { 'P', 'R', 'O', 'G', 'A', 'M', 'C', 'I', 'N' };

if (letras.All(letra => LetrasIntentadas.Contains(letra)))
{
    Terminado = true;
}
      }
    }
  

  
}
