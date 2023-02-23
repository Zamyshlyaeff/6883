// Показать натуральные числа от 1 до N, N задано
void Loop(int i, int N)
{
    Console.WriteLine($"{i}");
    if (i<N) Loop(i+1,N); //рекурсия
}
Loop(1,20);