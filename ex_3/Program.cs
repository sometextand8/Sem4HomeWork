// Задача 3: Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран.
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)


void CreateAnArray(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(101);
        Console.Write($"{array[i]} ");
    }
}


int[] Array = new int[8];

CreateAnArray(Array);