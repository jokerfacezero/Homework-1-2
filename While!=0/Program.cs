/*
С клавиатуры вводятся числа, пока не будет введен 0. 
Подсчитать сумму всех нечетных положительных чисел.
 */

int sum = 0;
bool flag = false;
do
{
    Console.WriteLine("Введите число от 1 до 100");
    int a = int.Parse(Console.ReadLine());
    if (a == 0)
    {
        flag = false;
    }
    else if (a > 101 || a < 0)
    {
        Console.WriteLine("Число вне диапозона, попробуйте еще раз");
        flag = true;
    }
    else if (a % 2 != 0 && a < 101 && a > 0)
    {
        sum = sum + a;
        flag = true;
    }
    else if (a % 2 == 0)
    {
        flag = true;
    }
} while (flag);
Console.WriteLine($"Sum = {sum}");
Console.ReadKey();
