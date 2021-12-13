bool stop = true;
string rightLog = "root";
string rightPass = "GeekBrains";
int ch = 1;
do
{
    Console.WriteLine("Давайте проверим, вы гость или уже пользователь? \n" +
        "У вас всего три попытки \n" +
        "Введите, пожалуйста, логин ");
    string login = Console.ReadLine();

    Console.WriteLine("А пароль?");
    string password = Console.ReadLine();


    if (login == rightLog && password == rightPass)
    {
        Console.WriteLine("Вы абсолютно правы!!");
        Console.ReadLine();
        Console.Clear();
        stop = false;
    }
    else if (ch == 3)
    {
        Console.WriteLine("Вы исчерпали кол-во попыток");
        stop = false;

    }

    else if (login != rightLog || password != rightPass)
    {
        Console.WriteLine(" Вы ввели неверные данные.  ");
        Console.WriteLine($" Это была {ch} попытка");
        ch++;


    }

}
while (stop);