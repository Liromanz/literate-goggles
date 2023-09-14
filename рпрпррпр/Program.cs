string txt;
do
{
    Console.WriteLine("Какой цвет вы любите?");
    Console.WriteLine("1. Черный");
    Console.WriteLine("2. Белый");
    Console.WriteLine("3. Серобуромалиновый");
    Console.WriteLine("4. Прозрачный");
    Console.WriteLine("5. никакой(((");
    txt = Console.ReadLine();
    if (txt == "1")
    {
        Console.WriteLine("а почему не белый");
    }
    else if (txt == "2")
    {
        Console.WriteLine("а почему не черный");
    }
} while (txt != "5");