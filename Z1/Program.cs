Console.Write("Введите число1: ");
string strNum1 = Console.ReadLine();
int a = int.Parse(strNum1);

Console.Write("Введите число2: ");
string strNum2 = Console.ReadLine();
int b = int.Parse(strNum2);

if (a > b)
{
Console.Write("max=");  
Console.WriteLine(a);
Console.Write("min=");  
Console.WriteLine(b);
}
else {Console.Write("max="); 
Console.WriteLine(b);
Console.Write("min=");  
Console.WriteLine(a);}
