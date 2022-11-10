//int ksayı = 1000000;
//for (int i = 0; i < 5; i++)
//{
//    int sayi = Convert.ToInt32(Console.ReadLine());
//    if (sayi < ksayı)
//        ksayı = sayi;
//}
//Console.WriteLine(ksayı);

// maximum değeri bulma  int sayı=int.Maxvalue;
//int sayi = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < sayi; i++)
//{
//    Console.Write("*");
//}


//int toplam = 0;
//int sayi = Convert.ToInt32(Console.ReadLine());

//while (sayi>0)
//{
//    toplam += sayi;
//}
//Console.WriteLine(toplam);



//int toplam = 0;
//int sayi = 1;
//while (sayi > 0)
//{
//    sayi = Convert.ToInt32(Console.ReadLine());
//    if (sayi > 0)
//        toplam += sayi;
//}
//Console.WriteLine(toplam);

int t = 0;
int s;
do
{
    s = Convert.ToInt32(Console.ReadLine());
    if (s > 0)
    {
        t += s;
    }
} while (s > 0);
{
    Console.WriteLine(t);
}


int toplam = 0;
int sayi = 1;
int sayıcı = 0;
while (sayi > 0)
{

    sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi > 0)
    {
        sayıcı++;
        toplam += sayi;
    }
}
Console.WriteLine($"girile sayıların toplamı {toplam}, ortalaması {(double)toplam/sayıcı}");
