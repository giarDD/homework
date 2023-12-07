// #Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// #и возвращает значение этого элемента или же указание, что такого элемента нет.

class Program
{
    static void Main()
    {
        int[,] array = {
            {10, 8, 1},
            {23, 44, 5},
            {17, 82, 99}
        };

        Console.Write("Введите номер строки: ");
        if (!int.TryParse(Console.ReadLine(), out int row))
        {
            Console.WriteLine("Нужно целое число");
            return;
        }

        Console.Write("Введите номер столбца: ");
        if (!int.TryParse(Console.ReadLine(), out int column))
        {
            Console.WriteLine("Нужно целое число");
            return;
        }

        int? element = GetElement(array, row, column);

        if (element.HasValue)
        {
            Console.WriteLine($"Значение элемента на позиции ({row}, {column}): {element.Value}");
        }
        else
        {
            Console.WriteLine($"Элемента на позиции ({row}, {column}) не существует.");
        }
    }

    static int? GetElement(int[,] array, int row, int column)
    {
        int numRows = array.GetLength(0);
        int numColumns = array.GetLength(1);

        if (row >= 1 && row <= numRows && column >= 1 && column <= numColumns)
        {
            return array[row - 1, column - 1];
        }
        else
        {
            return null; 
        }
    }
}
