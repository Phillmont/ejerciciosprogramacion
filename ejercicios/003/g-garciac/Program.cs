bool EsPrimo(int n) => n >= 2 && !Enumerable.Range(2, n - 2).Any(i => n % i is 0);
string Rotar(string s) => $"{s[1..]}{s[..1]}";
IEnumerable<int> Rotaciones(int n)
{
    int NumeroDeDigitos(int n) => n.ToString().Length;
    yield return n;
    var rotado = n.ToString();
    for (var i = 1; i < NumeroDeDigitos(n); i++)
    {
        rotado = Rotar(rotado);
        yield return int.Parse(rotado);
    }
}
bool EsPrimoCircular(int n) => Rotaciones(n).AsParallel().All(EsPrimo);
IEnumerable<int> ListaPrimos(int n) => Enumerable.Range(0, n - 1).AsParallel().Where(i => EsPrimo(i));
IEnumerable<int> ListaPrimosCirculares(int n) => ListaPrimos(n).AsParallel().Where(EsPrimoCircular);
ListaPrimosCirculares(200_000).AsParallel().OrderBy(n => n).ToList().ForEach(Console.WriteLine);