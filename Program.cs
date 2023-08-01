// Сумма чисел от 1 го до А

 static void Sum(int Num)
{
    int result=0;
    for (int i=1;i<=Num;i++)
    {
        result += i;
    }
    Console.WriteLine(result);
}
Console.WriteLine("Введите число");
int First = Convert.ToInt32(Console.ReadLine()!);
Sum(First);