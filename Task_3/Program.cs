// Показать числа Фибоначчи меньше заданного числа N
Console.Write("Enter your number N: ");
int n = int.Parse(Console.ReadLine()??"0");
int fib1=0;
int fib2=1;
int fibSum=0;
Console.Write($"{fib1} {fib2} ");
while (fib1+fib2<n)
{
    fibSum=fib1+fib2;
    fib1=fib2;
    fib2=fibSum;
    Console.Write($"{fibSum} ");
}
