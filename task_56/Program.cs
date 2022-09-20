/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка*/

int SmallSumElementRow(int[,] matrix) //Ищет строку с наименьшей суммой элементов
{
    int minRow = 0;
    int sumMin = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
        {                  
            sum += matrix[i,j];
        } 
        if (sum < sumMin || sumMin == 0)
    {
        sumMin = sum;
        minRow = i;
    }
    }
    
    return minRow;
}

int[,] GetArray(int row, int col, int beginNum, int endNum) //Создаем массив
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(beginNum, endNum + 1);
        }
    }
    return arr;
}
//Ввод значений
Console.Write("Введите количество строк для прямоугольного двумерного массива: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество cтолбцов для прямоугольного двумерного массива: ");
int col = int.Parse(Console.ReadLine());

if (row == col) //Проверка на прямоугольный массив
{    
    Console.WriteLine("Заданы значения не для прямоугольго массива");
    return;
}

Console.Write("Введите первое число диапозона: ");
int beginNum = int.Parse(Console.ReadLine());
Console.Write("Введите последнее число диапозона: ");
int endNum = int.Parse(Console.ReadLine());

int[,] MyMatrix = GetArray(row, col, beginNum, endNum); //Создать массив

void PrintArray(int[,] inArray) //Печать массива
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

PrintArray(MyMatrix);
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {SmallSumElementRow(MyMatrix) + 1} строка");;
