int Parse(string message)
{
    Console.WriteLine(message);
    string strNum = Console.ReadLine();
    int Num = int.Parse(strNum);
    return Num;
}
int Number = Parse("Введите число: ");
string strNumber = ($"{Number}");
int length = strNumber.Length;
int result = 0;

if (Number >= 0)
{
    for (int i = 0; i < length; i++)
    {
        result = result + int.Parse(Char.ToString (strNumber[i]));
    }
}
else
{
    for (int i = 1; i < length ; i++)
    {
        result = result + int.Parse(Char.ToString (strNumber[i]));
    }
}
Console.WriteLine(result);