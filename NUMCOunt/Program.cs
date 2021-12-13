/// <summary>
/// подсчет кол-ва цифр числа
/// </summary>

int a = 5578;
int count = 0;

for (int i = a; i != 0; count++)
{
    i /= 10;
}

/* по сути все тоже самое, просто решил попробовать
while (a > 0)
{
    a /= 10;
    count++;
}
*/
Console.WriteLine(count);
Console.ReadLine();

