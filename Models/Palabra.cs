 static class Palabra
{
  public static string palabra = "hola";

  public static bool Terminado = false;
    public static bool Completado = false;
public static int intentos = 0;
public static List< char> LetrasIntentadas { get; private set; } = new List<char>();

public static char Resultado(){
  char resultado = ' ';
    foreach(char l in palabra){
if( !LetrasIntentadas.Contains(l)){
resultado = '_';
}
else{
  resultado = l;
}
}
return resultado;
}
public static void IngresoPalabra(string palabra){
  intentos++;
  if(palabra == palabra){
Terminado = true;
  }
}
public static void IngresoLetra(char letra){
  if(! LetrasIntentadas.Contains(letra) && !Terminado){
    intentos++;
    LetrasIntentadas.Add(letra);

    Completado = true;
    foreach(char l in palabra){
if( !LetrasIntentadas.Contains(l)){
Completado = false;
}
if(Completado){
  Terminado = true;
}
    }
  }
  }
}
