// Преобразовать десятичное число в двоичное
Console.Write("Enter your decimal number: ");
int a = int.Parse(Console.ReadLine()??"0");
int b=0;
string result=" ";
while (a>0)
{
    b=a%2;
    result=b+result;
    a=a/2;
}
Console.Write($"Your binary number: {result}");

