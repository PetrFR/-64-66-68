Console.Write("Введите число N:");
string first = Console.ReadLine();
string last = ("1");
Console.WriteLine(NaturalNumbersString(first, last));

string NaturalNumbersString(string start, string end)
{
    if (start == end)
    {
        return start + ".";
    }
    else
    {
        return start + "," + NaturalNumbersString(Convert.ToString(int.Parse(start) - 1), end);
    }
}