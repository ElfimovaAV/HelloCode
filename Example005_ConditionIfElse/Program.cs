Console.Write("Введите имя пользователя: ");

if (Console.ReadLine()!.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(Console.ReadLine()!);
}