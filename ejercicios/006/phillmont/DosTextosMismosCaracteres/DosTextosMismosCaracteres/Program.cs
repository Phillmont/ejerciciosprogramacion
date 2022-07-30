bool ContienenLosMismosCaracteres (string string1,string string2)
{
    return string.Concat(string1.OrderBy(ch => ch)) == string.Concat(string2.OrderBy(ch => ch));
}

if (ContienenLosMismosCaracteres("A", "A") == false)
    Console.WriteLine("OK");
else
    Console.WriteLine("Error");
