Console.WriteLine("Введите три числа и я скажу, какое из них наибольшее и наименьшее");
Console.WriteLine("Первое число ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Второе число ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Последнее число ");
int num3 = int.Parse(Console.ReadLine());
int max = 0;

if (num1 >= num2 && num1 >= num3)
{
    max = num1;
}
else if (num1 <= num2 && num2 >= num3)
{
    max = num2;
}
else if (num3 >= num1 && num2 <= num3)
{
    max = num3;
}

Console.WriteLine($"Число {max} максимальное");

max = num1 <= num2 && num1 <= num3 ? num1 : (num2 <= num3 ? num2 : num3);
Console.WriteLine($"Число {max} минимальное");

Console.ReadKey();
Console.Clear();