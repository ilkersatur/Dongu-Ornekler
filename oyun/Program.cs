Random rand=new Random();
int random_sayi = rand.Next(1,101);
Console.WriteLine(random_sayi);
int sayac = 0;
while (true)
{

    int bizim_sayi = Convert.ToInt16(Console.ReadLine());
    int uzaklık = Math.Abs(random_sayi - bizim_sayi);
    sayac++;
    if (uzaklık >= 50)
    {
        Console.WriteLine(" çok uzaklaştın");
    }
    else if ((uzaklık) >= 20 && (uzaklık) <= 49)
    {
        Console.WriteLine(" uzaklaştın");
    }
    else if ((uzaklık) >= 10 && (uzaklık) <= 19)
    {
        Console.WriteLine("yakınlaştın");
    }
    else if (uzaklık > 0 && uzaklık <= 9)
    {
        Console.WriteLine(" çok yakınlaştın");
    }
    else
    {
        Console.WriteLine($" {sayac}.da bildin");
        break;
    }
}