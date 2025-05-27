using Newtonsoft.Json;

public static class Objetos{

public static string ListToString<T>(List<T> lista)
{
    return JsonConvert.SerializeObject(lista);
}

}

public static <T>? StringToObject<T>(string txt)
{
    if (string.IsNullOrEmpty(txt))
return default;
else

return JsonConvert. DeserializeObject<List<T>>(txt);
}
}