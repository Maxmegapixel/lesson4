// счастливое шестизначное число (сумма 1вых 3х цифр равна последним)

bool HappyNum(string Number)
{
        int sum1 = 0;
        int sum2 = 0;
        for (int i = 0; i < 3; i++)
        {
            sum1 += Number[i];
            sum2 += Number[i+3];
        }
        if (sum1 == sum2) return true;
        else return false;
}

Console.WriteLine("Введите число: ");
string Number = Console.ReadLine()!;
int count = Number.Length;
    Console.WriteLine($"Длина {count}");
    if (count != 6) Console.WriteLine($"Число {Number} не шестизначное");
    else 
    {
        if (HappyNum(Number) == true) Console.WriteLine($"Число {Number} счатливое");
        else Console.WriteLine($"Число {Number} не счатливое"); 
    }
