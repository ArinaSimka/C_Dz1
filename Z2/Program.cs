Console.Write("Введите число1: ");
string strNum1 = Console.ReadLine();
int a = int.Parse(strNum1);

Console.Write("Введите число2: ");
string strNum2 = Console.ReadLine();
int b = int.Parse(strNum2);

Console.Write("Введите число3: ");
string strNum3 = Console.ReadLine();
int c = int.Parse(strNum3);
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);

