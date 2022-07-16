{
    int totalnumeros = 0;
    for (int a = 1; a <= 100; a++)
    {
        string ta=a.ToString();
        int l=ta.Length;
        int suma = 0;
        for (int i = 0; i < l; i++)
        {
            string c = ta.Substring(i, 1);
            suma=suma+int.Parse(c);
        }
        if (a%suma == 0)
            totalnumeros=totalnumeros+1;
    }
    Console.WriteLine(totalnumeros);
}
