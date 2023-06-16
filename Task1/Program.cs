
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

void Min(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int g = 0; g < array.GetLength(1) - 1; g++)
      {
        if (array[i, g] < array[i, g + 1])
        {
          int temp = array[i, g + 1];
          array[i, g + 1] = array[i, g];
          array[i, g] = temp;
        }
      }
    }
  }
}


System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int [rows, cols];
FillArray(array);
PrintArray(array);
Min(array);
System.Console.WriteLine();
PrintArray(array);