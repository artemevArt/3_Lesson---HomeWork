// Console.WriteLine("Введите 5-и значное число: ");
// string num1 = Console.ReadLine();
// char[] num2 = num1.Reverse().ToArray();
// //Console.WriteLine(num2);
// int a = int.Parse(num1);
// int b = int.Parse(num2);
// if (a == b)
//     Console.WriteLine("является палиндромом");
// else Console.WriteLine("не является палиндромом");


// int x1 = 7, y1 = -5, z1 = 0,
//     x2 = 1, y2 = -1, z2 = 9;
Console.WriteLine("Введите координату X точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки А: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B: ");
int z2 = Convert.ToInt32(Console.ReadLine());

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
length = Math.Round(length,2);
Console.WriteLine($"Расстояние между точками в 3D пространстве: " + length);