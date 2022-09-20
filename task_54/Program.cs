/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int[,] SortElementsEachRow(int[,] matrix)
{
    int temp;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
       for(int j = 0; j < matrix.GetLength(1) - 1; j++)
       {                  
            if(matrix[i,j] < matrix[i,j+1])
            {
                temp = matrix[i,j];
                matrix[i,j] = matrix[i,j+1];
                matrix[i,j+1] = temp;
            }
        } 
    }
    return matrix;
}

int[,] GetArray(int row, int col, int beginNum, int endNum)
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

Console.Write("Введите количество строк : ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество cтолбцов: ");
int col = int.Parse(Console.ReadLine());
Console.Write("Введите первое число диапозона: ");
int beginNum = int.Parse(Console.ReadLine());
Console.Write("Введите последнее число диапозона: ");
int endNum = int.Parse(Console.ReadLine());

int[,] MyMatrix = GetArray(row, col, beginNum, endNum);

void PrintArray(int[,] inArray)
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
SortElementsEachRow(MyMatrix);
PrintArray(MyMatrix);



