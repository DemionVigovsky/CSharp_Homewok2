int number = 782;
Console.WriteLine(number);

int secondNumber = (number / 10) % 10;
int firstNumber = number / 100;
int thirdNumber = number % 10;

Console.WriteLine("вторая цифра числа - " + secondNumber);