// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int GetRandomNumber()
{
int number = new Random().Next(10, 100); //получаем случайное число из промежутка от 10 до 99
Console.Write(number); //выводим его на консоль
return number; //делаем возврат этого случ числа
}

int GetFirstDigit (int number1)
{
    number1 = number1 / 10; //Получаем целую часть числа
    return number1;
}

int num  =  GetRandomNumber(); //Присваиваем числу случ число
int FirstDigit = GetFirstDigit (num);//Получили первую цифру числа
// Console.WriteLine(FirstDigit); //Если надо будет вывести на экран

int GetLastDigit (int namber2)
{
    namber2 = namber2 % 10;
    return namber2;
}

int LastDigit = GetLastDigit (num);//Получили вторую цифру числа
// Console.WriteLine(LastDigit);

void ShowLargestDigit(int FirstDigit, int LastDigit)//Метод сравнения двух чисел
{
    if (FirstDigit > LastDigit)
    {
        Console.Write("-> " + FirstDigit);
    }
    else 
    Console.Write("-> " + LastDigit);
}
ShowLargestDigit(FirstDigit, LastDigit);//Сравнили два числа






