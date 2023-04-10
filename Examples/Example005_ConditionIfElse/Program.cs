Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine()!;

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ну что Манюня нужно позаниматься сегодня, а то итак целый день из телевизора не вылезаешь!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}