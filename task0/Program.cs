
// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя)
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(number * number);
if (number >= 100 && number <1000)
{
    int res = number % 10;
    Console.WriteLine(res + "= вторая цифра числа" +  number);

}
else
{
    Console.WriteLine("число не трёхзначное");
}