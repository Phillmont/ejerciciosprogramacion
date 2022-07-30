string GenerarFraseNueva(string frase, int repeticiones)
{
    string nuevaFrase = "";
    var vocales = new List<string> { "a", "e", "i", "o", "u" };
    for (int i = 0; i < frase.Length; i++)
    {
        if (vocales.Contains(frase.Substring(i, 1)))
        {
            if (repeticiones > 0)
            {
                for (var numrep = 1; numrep <= repeticiones; numrep++)
                    nuevaFrase = nuevaFrase + frase.Substring(i, 1);
            }
        }
        else
            nuevaFrase = nuevaFrase + frase.Substring(i, 1);
    }
    return nuevaFrase;
}

Console.WriteLine(GenerarFraseNueva("felipe", 1));