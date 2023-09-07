Console.Write("Введите число: ");
string strNum = Console.ReadLine();
int n = int.Parse(strNum);

if(n % 2 == 0) {Console.WriteLine("ДА, это чисто четное");}
else {Console.WriteLine("НЕТ, это число нечетное");}
