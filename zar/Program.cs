Random rand = new Random();

while (true)
{
    int random_sayi = rand.Next(1, 7);
    Console.WriteLine(random_sayi);

    if (random_sayi == 6)
    {
        Console.WriteLine("oldu");
        break;
    }
}

//int deneme;
//do
//{
//    deneme = new Random().Next(1,7);
//    Console.WriteLine(deneme);

//} while (deneme!=6)
//        Console.WriteLine("oldu"); 
//;