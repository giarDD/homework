
// Задача 3: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов

class Program
{
    static void Main()
    {
        int[,] array = {
            {99, 0, 0},
            {0, 10, 98},
            {0, 2, 9},
            {1, 1, 1}
        };

        Console.WriteLine("\nИсходный массив:\n");
        PrintArray(array);

        int minSumRowIndex = FindRowWithMinSum(array);

        Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minSumRowIndex + 1}\n");
    }

    static void PrintArray(int[,] array)
    {
        int numRows = array.GetLength(0);
        int numColumns = array.GetLength(1);

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numColumns; j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    static int FindRowWithMinSum(int[,] array)
    {
        int numRows = array.GetLength(0);
        int numColumns = array.GetLength(1);

        int minSum = int.MaxValue;
        int minSumRowIndex = -1;

        for (int i = 0; i < numRows; i++)
        {
            int rowSum = 0;

            for (int j = 0; j < numColumns; j++)
            {
                rowSum += array[i, j];
            }

            if (rowSum < minSum)
            {
                minSum = rowSum;
                minSumRowIndex = i;
            }
        }

        return minSumRowIndex;
    }
}