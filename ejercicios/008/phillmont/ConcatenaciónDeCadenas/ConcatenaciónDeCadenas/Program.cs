List<string> ObtenerCadenasOriginales()
{
    var cadenas = new List<string> ();
    string respuesta = "";
    while (respuesta != "fin")
    {
        Console.Clear();
        Console.WriteLine("Introduzca cadena, o fin para terminar");
        respuesta = Console.ReadLine();
        if (respuesta != "fin")
            cadenas.Add (respuesta);
    }
    return cadenas;
}

List<string> GenerarCadenasCombinadas (List<string> CadenasOriginales)
{
    var cadenasCombinadas=new List<string> ();
    foreach (var cadenaOriginal in CadenasOriginales)
    {
        int longitudCadena = cadenaOriginal.Length;
        for (int i = 0; i < longitudCadena; i++)
        {
            cadenasCombinadas.Add(cadenaOriginal.Substring(i, 1) + cadenaOriginal);
        }

    }
    return cadenasCombinadas;
}

var cadenasOriginales = ObtenerCadenasOriginales();
var cadenasCombinadas=GenerarCadenasCombinadas(cadenasOriginales);
Console.Clear();
foreach (var cadena in cadenasCombinadas)
{
    Console.WriteLine (cadena);
}
