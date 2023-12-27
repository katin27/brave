// комментарий

// тип данных,имя переменной = значение;
// camelCase: firstNumber, secoydNumber
// int number = 9;
// int result = number * number; 
Console.WriteLine("введите число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber == secondNumber * secondNumber)
{ 
    Console.WriteLine("Да, " + firstNumber + " явл кв от числа " + secondNumber);
}



