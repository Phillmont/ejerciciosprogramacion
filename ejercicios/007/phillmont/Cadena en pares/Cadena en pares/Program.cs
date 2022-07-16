string[] generarparesdelacadena(string cadena)
{
    int lc = cadena.Length;
    string[] pares = new string[lc];
    for (int i = 0; i < lc; i++)
    {
        pares[i] = cadena.Substring(i, 1) + ", " + cadena.Substring(0, i) + cadena.Substring(i + 1, lc - i - 1);
    }
    return pares;
}

Console.WriteLine("Introduzca una frase:");
string frase = Console.ReadLine();
Console.WriteLine();
string[] pares = generarparesdelacadena(frase);
foreach (string cadena in pares)
    Console.WriteLine(cadena);
