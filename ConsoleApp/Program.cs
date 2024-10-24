// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



void WriteEven()
{
    Console.WriteLine("Podaj n");
    var n = Console.ReadLine();

    for (var i = 0; i < int.Parse(n); i += 2) // i = i+2;
    {
        Console.WriteLine(i);
    }
}


while (true)
{
    Console.WriteLine("Wybierz");
    Console.WriteLine("1. Liczby parzyste");
    Console.WriteLine("2. Silnia");
    Console.WriteLine("0. Wyjście");

    var n = Console.ReadLine();

    switch (int.Parse(n))
    {
        case 1:
            {
                WriteEven();
                break;
            }
        case 2:
            {
                var siln = Console.ReadLine();
                Console.WriteLine(Silnia(int.Parse(siln)));
                break;
            }
    }

    if (int.Parse(n) == 0) break;
}


int Silnia(int x)
{
    if(x == 0) return 1;

    return Silnia(x - 1) * x;
}
