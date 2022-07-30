int[] calcularlargodecadenayarchivo()
{
    int[] tamano = new int[2];
    foreach (string NumeroGrande in CargarDatosDesdeArchivo())
    {
        int lc = NumeroGrande.Length;
        if (lc > tamano[0])
            tamano[0] = lc;
        tamano[1]++;
    }
    return tamano;
}

IEnumerable<string> CargarDatosDesdeArchivo()
{
    return System.IO.File.ReadLines("numbers.txt");
}

string[] creararreglouniforme(int t, int l)
{
    int c = 0;
    string[] NumerosGrandes = new string[t];
    foreach (string NumeroGrande in CargarDatosDesdeArchivo())
    {
        NumerosGrandes[c] = NumeroGrande.PadLeft(l, '0');
        c++;
    }
    return NumerosGrandes;
}

string sumarnumeros(string[] numeros, int l)
{
    int llevar = 0;
    int cc = 0;
    string suma = "";
    for (int i = l - 1; i > -1; i--)
    {
        int res = 0;
        foreach (string numero in numeros)
        {
            res = res + int.Parse(numero.Substring(i, 1));
        }
        res = res + llevar;
        string restring = res.ToString();
        int lres = restring.Length;
        if (lres > 1)
        {
            suma = suma.Insert(0, restring.Substring(lres - 1, 1));
            llevar = int.Parse(restring.Substring(0, lres - 1));
        }
        else
        {
            suma = suma.Insert(0, restring);
            llevar = 0;
        }
        if (i > 0)
        {
            cc++;
            if (cc == 3)
            {
                suma = suma.Insert(0, ",");
                cc = 0;
            }
        }
        else
            continue;
    }
    if (llevar > 0)
    {
        cc++;
        if (cc == 3)
        {
            suma = suma.Insert(0, ",");
            suma = suma.Insert(0, llevar.ToString());
            cc = 0;
        }
        else
            suma = suma.Insert(0, llevar.ToString());
    }
    return suma;
}


int[] tl = calcularlargodecadenayarchivo();
//Console.WriteLine();
//Console.WriteLine("Hay {0} números.", tl[1]);
//Console.WriteLine("La cadena mas larga es de {0} caracteres.", tl[0]);

string[] arreglonumeros = creararreglouniforme(tl[1], tl[0]);
//Console.WriteLine();
//foreach (string arreglo in arreglonumeros)
//{
//    Console.WriteLine(arreglo);
//}

string resultadodelasuma = sumarnumeros(arreglonumeros, tl[0]);
Console.WriteLine();
Console.WriteLine(resultadodelasuma);