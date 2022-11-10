// döngülerin belirli sayıda çalışması
for (int i = 0; i < 0; i++)
{
    Console.WriteLine();
}

//int i = 0;
//while (i < 1)
//{
//    Console.WriteLine();
//    i++;
//}

int k = 0;
do
{
    Console.WriteLine();
    k++;
} while (k < 5);

for (; ; )
{
    Console.WriteLine();  //bu döngüyü kırmak için break
}

for (int i = 0; i < 5; i++)
{
    if (i == 3) continue;  // şartı atlar ve sonuc 0 - 1 - 2 - 4 
    {
        Console.WriteLine(i);
    }
}

// iç içe döngüler  nested loops

for (int i = 0; i < 5; i++)
{
	for (int j = 0; j < 5; j++)
	{
        Console.Write(j);
    }
    Console.WriteLine($" {i}");
}