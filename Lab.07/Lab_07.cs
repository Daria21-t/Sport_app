using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

bool running = true;

while (running)
{
    Console.WriteLine("=== СПОРТИВНІ ЗМАГАННЯ ===");
    Console.WriteLine("1 — Про програму");
    Console.WriteLine("2 — Таблиця вартості");
    Console.WriteLine("3 — Результати команд");
    Console.WriteLine("0 — Вихід");

    Console.Write("Ваш вибір: ");
    string choice = Console.ReadLine();

    Console.WriteLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("=== ПРО ПРОГРАМУ ===");
            Console.WriteLine("Тема: Спортивні змагання");
            Console.WriteLine("Головна сутність: результат учасника");
            Console.WriteLine("Підсумкова величина: медальний залік по командах.");
            break;

        case "2":
            Console.WriteLine("Таблиця вартості буде пізніше.");
            break;

        case "3":
            Console.WriteLine("Результати команд будуть пізніше.");
            break;

        case "0":
            running = false;
            Console.WriteLine("До побачення!");
            break;

        default:
            Console.WriteLine("Немає такого пункту. Спробуйте ще раз.");
            break;
    }

    if (running)
    {
        Console.WriteLine();
        Console.WriteLine("Натисніть Enter для продовження...");
        Console.ReadLine();
        Console.Clear();
    }
}