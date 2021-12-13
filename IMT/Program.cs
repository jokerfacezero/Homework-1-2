Console.WriteLine("Индекс массы тела (англ. body mass index (BMI), ИМТ) — величина, позволяющая оценить степень соответствия \n" +
               "массы человека и его роста и тем самым косвенно судить о том,\n" +
               "является ли масса недостаточной, нормальной или избыточной");
Console.WriteLine("Введите свой рост в метрах(165 см = 1,65 м )");
double lnght = double.Parse(Console.ReadLine());
Console.WriteLine("Введите свой вес ");
double wght = double.Parse(Console.ReadLine());
double i = wght / (lnght * lnght);
Console.WriteLine($"{i:F2}") ;
if (i < 16)
{
    Console.WriteLine("Выраженный дефицит массы тела!");
    double rightWght1 = 18.6 * (lnght * lnght) - wght;
    double rightWght2 = 24.9 * (lnght * lnght) - wght;
    Console.WriteLine($" Вам нужно набрать от {rightWght1:F2} до {rightWght2:F2} кг");
}
else if (i > 16 && i < 18.5)
{
    double rightWght1 = 18.6 * (lnght * lnght) - wght;
    double rightWght2 = 24.9 * (lnght * lnght) - wght;
    Console.WriteLine("Недостаточная(дефицит) масса тела");
    Console.WriteLine($" Вам нужно набрать от {rightWght1:F2} до {rightWght2:F2} кг");
}
else if (i > 18.5 && i < 25)
{
    Console.WriteLine("Норма");

}
else if (i > 25 && i < 30)
{
    Console.WriteLine("Избыточная масса тела(предожирение)");
    double rightWght1 = 18.6 * (lnght * lnght) - wght;
    double rightWght2 = 24.9 * (lnght * lnght) - wght;
    Console.WriteLine($" Вам нужно набрать от {-rightWght2:F2} до {-rightWght1:F2} кг");
}
else if (i > 30 && i < 35)
{
    Console.WriteLine("Ожирение 1 степени");
    double rightWght1 = 18.6 * (lnght * lnght) - wght;
    double rightWght2 = 24.9 * (lnght * lnght) - wght;
    Console.WriteLine($" Вам нужно набрать от {-rightWght2:F2} до {-rightWght1:F2} кг");

}
else if (i > 35 && i < 40)
{
    Console.WriteLine("Ожирение 2 степени");
    double rightWght1 = 18.6 * (lnght * lnght) - wght;
    double rightWght2 = 24.9 * (lnght * lnght) - wght;
    Console.WriteLine($" Вам нужно набрать от {-rightWght2:F2} до {-rightWght1:F2} кг");
}
else if (i > 40)
{
    Console.WriteLine("Ожирение 3 степени");
    double rightWght1 = 18.6 * (lnght * lnght) - wght;
    double rightWght2 = 24.9 * (lnght * lnght) - wght;
    Console.WriteLine($" Вам нужно набрать от {-rightWght2:F2} до {-rightWght1:F2} кг");
}
Console.ReadLine();