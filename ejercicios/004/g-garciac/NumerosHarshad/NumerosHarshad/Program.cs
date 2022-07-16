bool EsHarshad(int n)
{
    var sumaDigitos = 0;
    foreach (var c in n.ToString())
    {
        int valNum = (int)c - 48;
        sumaDigitos+=valNum;
    }
    return n % sumaDigitos is 0;
}
bool EsHarshad2(int n) => n % n.ToString().Select(c => (int)c - 48).Sum() is 0;

/// <summary>
/// Cuenta cuantos numero de H......
/// A partir de 1 a n
/// </summary>
int ContarNumerosHarshad(int n)
{
    var result = 0;
    for (int i = 1; i <= n; i++)
    {
        if (EsHarshad(i))
            result++;
    }
    return result;
}

//Console.WriteLine(ContarNumerosHarshad(100_000_000));
//Console.ReadLine();

Func<int, int> problema = (n) => 
    Enumerable.Range(1, n).AsParallel()
     .Select(n => n % n.ToString()
     .Select(c => (int)c - 48).Sum() is 0)
     .Count(c => c is true);

Console.WriteLine(problema(100));