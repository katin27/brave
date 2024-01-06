// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// // "&&" - "И": яблоки и апельсины
// // "||" - "ИЛИ" 
// if (number >= 100 && number <= 999) // трехзначчное число
// {
//     int firstDigit = number / 100;
//     int thitdDigit = number % 10;
//     int result = firstDigit * 10 + thitdDigit;
//     Console.WriteLine($"результат от числа {number} = {result}");
// }
// else // не трехзначное
// {
//     Console.WriteLine("Число не трехзначное");
// }
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number >= 100 && number <= 999)
// {
//     int sekondDigit = number / 10 % 10;
//     int thirdDigit = number % 10;
//     int result = (int)Math.Pow(sekondDigit, thirdDigit);
//     Console.WriteLine($"Число {number}:{sekondDigit}^{thirdDigit} = {result}");
// }
// else // не трехзначное
//  {
//     Console.WriteLine("Число не трехзначное");
//  }

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10 && number <= 99)
{
    int firstNumber = number / 10;
    int secondNumber = number % 10;
    int max = firstNumber;
    while (secondNumber > max)
    {
        max = secondNumber;
    }
    Console.WriteLine(max);
}

