// Задача 2: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.
class Program
{
    static void Main()
    {
    
        int[,] array = {
            {9, 9, 9},
            {6, 6, 6},
            {5, 5, 5},
            {4, 4, 4},
            {0, 0, 0}
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        
        SwapRows(array, 1, array.GetLength(0));

        Console.WriteLine("Массив после замены строк:");
        PrintArray(array);
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

    static void SwapRows(int[,] array, int row1, int row2)
    {
        int numColumns = array.GetLength(1);

        
        if (row1 >= 1 && row1 <= array.GetLength(0) && row2 >= 1 && row2 <= array.GetLength(0))
        {
            for (int j = 0; j < numColumns; j++)
            {
                int temp = array[row1 - 1, j];
                array[row1 - 1, j] = array[row2 - 1, j];
                array[row2 - 1, j] = temp;
            }
        }
        else
        {
            Console.WriteLine("Ошибка: указанные строки находятся вне допустимых границ массива.");
        }
    }
}
