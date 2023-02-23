// Показать натуральные числа от N до 1, N задано
void Print(int i,int N)
{   Console.WriteLine($"{N}");
    if (N>i) 
     Print(i,N-1); 
     
}
Print(1,8);