// комментарий

// тип данных,имя переменной = значение;
// camelCase: firstNumber, secoydNumber
// int number = 9;
// int result = number * number; 
// Console.WriteLine("введите число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if(firstNumber == secondNumber * secondNumber)
// { 
//     Console.WriteLine("Да, " + firstNumber + " явл кв от числа " + secondNumber);
// }

// Console.Write("введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите певрое число: "); 
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber == secondNumber * secondNumber)
{
   Console.WriteLine("Да, " + firstNumber + " явл кв от числа " + secondNumber);
}
else
{
   Console.WriteLine("нет, " + firstNumber + " не явл кв от числа " + secondNumber);
}