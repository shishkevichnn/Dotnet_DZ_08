/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/
//Ввод значений
Console.Write("Введите количество строк (не более 30): ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите количество cтолбцов (не более 30): ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите количество колонок (не более 30): ");
int c = int.Parse(Console.ReadLine());

if (a > 30 || b > 30 || c> 30) //Проверка на количество двузначных чисел
{    
    Console.WriteLine("Вы ввели размер матрицы больше 30, повторите попытку");
    return;
}
int Mysize = a * b * c;

int[] GetOneArray(int size, int minValue, int maxValue) //Создаем 1 мерный массив из неповторяющихся двузначных чисел
{
    int[] array = new int[size];
    array[0] = new Random().Next(minValue, maxValue+1);
        for (int i = 1; i < array.GetLength(0);)
        {
            int num = new Random().Next(minValue, maxValue+1); // генерируем элемент
            int j;
            for (j = 0; j < i; j++)
            {
                if (num == array[j])
                break; // совпадение найдено, элемент не подходит
            }
            if (j == i)
            { // совпадение не найдено
                array[i] = num; // сохраняем элемент
                i++; // переходим к следующему элементу
            }
        }
        return array;
}

int[,,] GetArray(int[] MyArray) //Создаем трехмерный массив 
{
    int[,,] arr = new int[MyArray.GetLength(0) / 3, MyArray.GetLength(0) / 3, MyArray.GetLength(0) / 3];
    int index1 = 0;
    int index2 = 0;
    int index3 = 0;
    for (int i = 0; i < arr.GetLength(0) / 3; i++)
    {
        for (int j = 0; j < arr.GetLength(0) / 3; j++)
        {
            for (int k = 0; k < arr.GetLength(0) / 3; k++)
            {
                arr[index1, index2, index3] = MyArray[i];
                index1++;
                index2++;
                index3++;
            }
        }
    }
    return arr;
}

void PrintArray(int[,,] inArray) //Печатаем матрицу
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]}({i}, {j}, {k}) ");
                
            }
            Console.WriteLine();
        }
    }
    
}
int[] ArrayFirst = GetOneArray(Mysize, 10, 98);
Console.WriteLine($"[{String.Join(", ", ArrayFirst)}]");
int[,,] ArraySecond = GetArray(ArrayFirst);
//int[,,] MyMatrix = GetArray(int[] array); //Создаем трехмерный массив из одномерного

PrintArray(ArraySecond); //Вывод на экран
Console.WriteLine();
//Console.WriteLine(String.Join(" ", GetRowArray(MyMatrix)));


