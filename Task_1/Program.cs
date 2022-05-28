// Выяснить- являются ли три числа сторонами треугольника
Console.Write("Enter your first number: ");
int a = int.Parse(Console.ReadLine()??"0");
Console.Write("Enter your second number: ");
int b = int.Parse(Console.ReadLine()??"0");
Console.Write("Enter your third number: ");
int c = int.Parse(Console.ReadLine()??"0");
if (a+b>c&&b+c>a&&a+c>b) Console.Write("These numbers are sides of the triangle");
else Console.Write("These numbers are not sides of the triangle");
