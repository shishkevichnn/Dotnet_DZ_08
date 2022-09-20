/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

void ProductTwoMatrics(int[,] MatrixFirst, int[,] MatrixSecond, int[,] MatrixEnd) //Произведение двух матриц
{
    for(int i = 0; i < MatrixEnd.GetLength(0); i++)
    {
        for(int j = 0; j < MatrixEnd.GetLength(1); j++)
        {                  
            int temp = 0;
            for (int k = 0; k < MatrixFirst.GetLength(1); k++)
            {
                temp += MatrixFirst[i,k] * MatrixSecond[k,j];
            }
        MatrixEnd[i,j] = temp;
        } 
    }
}

int[,] GetArray(int row, int col, int beginNum, int endNum) //Создаем матрицу 
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

void PrintArray(int[,] inArray) //Печатаем матрицу
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

//Ввод значений
Console.Write("Введите количество строк 1 матрицы: ");
int rowFirst = int.Parse(Console.ReadLine());
Console.Write("Введите количество cтолбцов 1 матрицы: ");
int colFirst = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк 2 матрицы: ");
int rowSecond = int.Parse(Console.ReadLine());
Console.Write("Введите количество cтолбцов 2 матрицы: ");
int colSecond = int.Parse(Console.ReadLine());
Console.Write("Введите первое число диапозона матриц: ");
int beginNum = int.Parse(Console.ReadLine());
Console.Write("Введите последнее число диапозона матриц: ");
int endNum = int.Parse(Console.ReadLine());

int[,] MyMatrixFirst = GetArray(rowFirst, colFirst, beginNum, endNum); //Создать массив 1
int[,] MyMatrixSecond = GetArray(rowSecond, colSecond, beginNum, endNum); //Создать массив 2
int[,] MyMatrixEnd = new int[rowFirst, colSecond]; //Создать финальный массив
PrintArray(MyMatrixFirst); //Вывод на экран
Console.WriteLine();
PrintArray(MyMatrixSecond);
Console.WriteLine();
Console.WriteLine($"Результирующая матрица будет:");
ProductTwoMatrics(MyMatrixFirst, MyMatrixSecond, MyMatrixEnd);
PrintArray(MyMatrixEnd);
