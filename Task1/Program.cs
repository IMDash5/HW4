int Parse(string message)
{
    Console.WriteLine(message);
    string strNum = Console.ReadLine();
    int Num = int.Parse(strNum);
    return Num;
}

double Num1 = Parse("Введите первое число: ");
double Num2 = Parse("Введите второе число: ");
double result = 0;

if (Num2 >= 0)
{
    result = Math.Pow(Num1, Num2);
    Console.WriteLine(result);
}
else 
{
    result = Math.Pow(Num1, -Num2);
    Console.WriteLine(result);
}