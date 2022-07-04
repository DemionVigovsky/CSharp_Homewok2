Console.WriteLine("Введите число дня недели");
int weekNumber = Convert.ToInt32(Console.ReadLine());

if(weekNumber == 6 || weekNumber == 7)
{
    Console.WriteLine("Да, это выходной день");
} 
if (weekNumber < 1 || weekNumber > 7)
{
    Console.WriteLine ("Ошибка! Введите число от 1 до 7");
}
if(weekNumber == 1 || weekNumber == 2 || weekNumber == 3 || weekNumber == 4 || weekNumber == 5)
    {
    Console.WriteLine("Нет, это будний день");
    }

