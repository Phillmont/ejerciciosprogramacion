bool EsPrimo(int n)
{
    var ep = true;
    if (n > 1)
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
                ep = false;
        }
    return ep;
}

bool SonPrimosCirculares(int[] n)
{
    var epc = true;
    foreach (int i in n)
    {
        if (!EsPrimo(i))
            epc = false;
    }
    return epc;
}

int[] CalcularNumerosCirculares(int n)
{
    string cadena_n = n.ToString();
    int l = cadena_n.Length;
    int[] pc = new int[l];
    for (int i = 0; i < l; i++)
    {
        string nuevacadena = cadena_n.Substring(l - 1, 1) + cadena_n.Substring(0, l - 1);
        var nuevacadenanum = int.Parse(nuevacadena);
        pc[i]= nuevacadenanum;
        cadena_n = nuevacadena;
    }
    return (pc);
}

for (int x = 1; x < 1000; x++)
{
    if (!EsPrimo(x))
        continue;
    int[] circulares= CalcularNumerosCirculares(x);
    if (SonPrimosCirculares(circulares))
        Console.WriteLine(x);
}