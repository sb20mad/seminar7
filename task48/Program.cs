// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
// Aₘₙ = m+n. Выведите полученный массив на экран.

// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
Console.Write("Количество строк"); 
int m = Convert.ToInt32(Console.ReadLine());//число строк
Console.Write("Количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());//число столбцов
int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = i+j;
        }
    }

    return matrix;
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



// Console.Write("Введите m и n через Enter "); 
// int m = Convert.ToInt32(Console.ReadLine());//число строк
// int n = Convert.ToInt32(Console.ReadLine());//число столбцов
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);