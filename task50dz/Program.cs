// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1  7 -> такого числа в массиве нет

//Console.Write("Введите m и n через Enter "); 
int m = 5;//Convert.ToInt32(Console.ReadLine());//число строк
int n = 5;//Convert.ToInt32(Console.ReadLine());//число столбцов
Console.Write("Введите номер столбца и номер строки искомого числа через Enter "); 
int z = Convert.ToInt32(Console.ReadLine()) - 1;//строка
int x = Convert.ToInt32(Console.ReadLine()) - 1;//столбец
int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
//Console.Write("______________");
  if (z < 0 & x > matrix.GetLength(0) - 1 & x < 0 & x > matrix.GetLength(1) - 1)
            {
                Console.WriteLine("такого числа в массиве нет");
            }
            else
            {
                Console.WriteLine($"Значение числа в массиве = {matrix[z, x]}");
            }


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

