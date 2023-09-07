Console.Write("Введите число: ");
string strNum = Console.ReadLine();
int n = int.Parse(strNum);

while (n>0)
{
if(n % 2 == 0) {Console.WriteLine(n);}
n = n - 1;
}
