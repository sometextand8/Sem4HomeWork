//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double Kwadrat(int A, int B)
{
    double answer = Math.Pow(A, B);
    return answer;
}


double X = Kwadrat(4, 3);

Console.WriteLine(X);


// Задача 1 через цикл


int N(int number, int n)
{
    int ans = 1;
    for (int i = 0; i < n; i++)
    {
        ans = ans * number;
    }
    return ans;

}


Console.WriteLine(N(2, 5));