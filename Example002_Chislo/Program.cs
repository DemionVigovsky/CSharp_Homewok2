/*int numberA = new Random().Next(100,999);
Console.WriteLine (numberA);
int firstNumber = numberA / 100;
int thirdNumber = numberA % 10;
Console.WriteLine(firstNumber * 10 + thirdNumber);*/

int secondNumber (int first, int third)
{
    int numberA = new Random().Next(first, third);
    Console.WriteLine (numberA);
    int firstNumber = numberA / 100;
    int thirdNumber = numberA % 10;
    int result = firstNumber * 10 + thirdNumber;
    return result;
}


int A = secondNumber (100,999);
Console.WriteLine (A);
