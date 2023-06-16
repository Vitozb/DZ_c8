void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(0,31);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],3}    ");
        System.Console.WriteLine();
        }
}

void Str(int[,] array)
{
    int minSum = 0;        
    int sum = SumElements(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
        {
            int tempSum = SumElements(array, i);
            if (sum > tempSum)
            {
                sum = tempSum;
                minSum = i;
            }
}
            Console.WriteLine("Строка: "+minSum+" Сумма - "+sum);
            Console.WriteLine();
}
int SumElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int [rows, cols];
FillArray(array);
PrintArray(array);
Str(array);


