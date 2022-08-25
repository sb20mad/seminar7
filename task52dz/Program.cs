// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int m = 3;//Convert.ToInt32(Console.ReadLine());//число строк
int n = 3;//Convert.ToInt32(Console.ReadLine());//число столбцов
int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = 1, int rightRange = 10)
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
PrintMatrix(matrix);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    double sum = 0;
    double sred = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[j, i];
        //sred = sum / matrix.GetLength(1);
        sred = Math.Round(sum / matrix.GetLength(1), 2);
    }
    Console.WriteLine($"Столбец {i + 1} Сумма: {sum}");
    Console.WriteLine($"Среднее: {sred}");
}
