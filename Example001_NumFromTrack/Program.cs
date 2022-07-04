int number = new Random().Next(10,99);
Console.WriteLine(number);

int secondnumber = number % 10;
int firstnumber = number / 10;
int max = 0;

if(firstnumber > secondnumber) max = firstnumber;
if(secondnumber > firstnumber) max = secondnumber;

Console.WriteLine(max);