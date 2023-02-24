// Найти сумму цифр числа
int a;
int SUMM(int N)
{   
    
     if (N==0) return 0;
     else
    
     return a=SUMM(N/10)+N%10;
}
Console.WriteLine(SUMM(158));