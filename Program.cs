Console.WriteLine("Введите 5-и значное число: ");
string num1 = Console.ReadLine();
char[] num2 = num1.Reverse().ToArray();
//Console.WriteLine(num2);
int a = int.Parse(num1);
int b = int.Parse(num2);
if (a == b)
    Console.WriteLine("является палиндромом");
else Console.WriteLine("не является палиндромом");