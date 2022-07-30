int[] GetNumberOfLinesAndColumns()
{
    int[] fileSize = new int[2];
    foreach (string bigNumber in LoadDataFromFile())
    {
        int stringLength = bigNumber.Length;
        if (stringLength > fileSize[0])
            fileSize[0] = stringLength;
        fileSize[1]++;
    }
    return fileSize;
}

string[] StandardizeTheSizeOfArrayRows(int largeArray, int widthArray)
{
    int counter = 0;
    string[] bigNumbers = new string[largeArray];
    foreach (string bigNumber in LoadDataFromFile())
    {
        bigNumbers[counter] = bigNumber.PadLeft(widthArray, '0');
        counter++;
    }
    return bigNumbers;
}

string GetSumOfBigNumers(string[] numbers, int columns)
{
    int carry = 0;
    string sum = "";
    for (int i = columns - 1; i > -1; i--)
    {
        int sumResult = 0;
        foreach (string number in numbers)
            sumResult = sumResult + int.Parse(number.Substring(i, 1));
        sumResult = sumResult + carry;
        string sumResultToString = sumResult.ToString();
        int lengthResult = sumResultToString.Length;
        if (lengthResult > 1)
        {
            sum = sum.Insert(0, sumResultToString.Substring(lengthResult - 1, 1));
            carry = int.Parse(sumResultToString.Substring(0, lengthResult - 1));
        }
        else
        {
            sum = sum.Insert(0, sumResultToString);
            carry = 0;
        }
    }
    if (carry > 0)
        sum = sum.Insert(0, carry.ToString());
    return sum;
}

string FormatResult (string resultToFormat)
{
    int digitCounter = 0;
    int columns = resultToFormat.Length;
    for (int i = columns - 1; i > -1; i--)
    {
        digitCounter++;
        if (digitCounter == 3)
        {
            resultToFormat = resultToFormat.Insert(i, ",");
            digitCounter = 0;
        }
    }
    return resultToFormat;
}

IEnumerable<string> LoadDataFromFile()
{
    return System.IO.File.ReadLines(@"C:\Users\Phill\repos\ejerciciosprogramacion\ejercicios\005\numbers.txt");
}

int[] size = GetNumberOfLinesAndColumns();
int columns = size[0];
int lines = size[1];
string[] standarizedArray = StandardizeTheSizeOfArrayRows(lines, columns);
string sumResult = GetSumOfBigNumers(standarizedArray, columns);
string formatedResult = FormatResult(sumResult);
Console.WriteLine();
Console.WriteLine(formatedResult);