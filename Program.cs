// Произведение чисел от 1 го до А

 static int ProdGet(int Num)
{
    int result=1;
    for (int i=1;i<=Num;i++)
    {
        result *= i;
    }
    return result;
}
Console.WriteLine("Введите число");
int First = Convert.ToInt32(Console.ReadLine()!);
int Sum = ProdGet(First);
Console.WriteLine($"Сумма равна: {Sum}");