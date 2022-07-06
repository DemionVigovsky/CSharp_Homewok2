void twoNumbers (int numberA, int numberB)
{
    if (numberA % numberB == 0)
    {
        Console.WriteLine ("Кратное");
    }
    else
    {
        Console.WriteLine ("Не кратное, остаток " + numberA % numberB);
    }
}

twoNumbers (110, 21);