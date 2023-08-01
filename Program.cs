// двоичный массив из восьми элементов

int[] ArrMet(int Size)
{
    int[] Arr = new int[Size];
    for (int i = 0; i<Size; i++)
    {
        Arr[i]= new Random().Next(2);
    }
    return Arr;
}
int[] massive = ArrMet(8);
Console.WriteLine($"{String.Join(" ", massive)}");