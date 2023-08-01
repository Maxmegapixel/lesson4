// счастливое шестизначное число (сумма 1вых 3х цифр равна последним)

static void HappyNum(string Number)
{
    int count = Number.Length;
    Console.WriteLine($"Длина {count}");
    if (count != 6) 
    {
        Console.WriteLine($"Число {Number} не шестизначное");
    }
    else
    {
        int sum1 = 0;
        int sum2 = 0;
        for (int i = 0; i < count/2; i++)
        {
            sum1 += Number[i];
            sum2 += Number[i+3];
        }
        if (sum1 == sum2) Console.WriteLine($"Число {Number} счатливое");
        else Console.WriteLine($"Число {Number} не счатливое");
    }
   
}

Console.WriteLine("Введите число: ");
string Num1 = Console.ReadLine()!;
HappyNum(Num1);