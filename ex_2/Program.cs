// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


void LengthOfnum(string num)
{
    int len = num.Length;
    Console.WriteLine($"В числе {num}, кол. чисел = {len}.");

}


LengthOfnum("123123123");


// Задача 2 


void LenOfInput(int number)
{
    int showNum = number;
    int count = 0;

    while (number % 10 > 0)
    {
        number /= 10;
        count ++;
    }

    Console.WriteLine($"В числе {showNum}, кол.во цифр = {count}.");

}

LenOfInput(76);