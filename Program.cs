/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
/*
int FiveDigNumber(int number)
{
    int thous = number / 10000;
    int ed = number % 10;
    if (thous == ed)
    {
    Console.WriteLine("Да");
    }
    else
    
        {
            Console.WriteLine("Нет");
        }
    return number;    
    
}
Console.WriteLine("Input a five digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = FiveDigNumber(number);
*/


/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*
double FindLenght(double x1, double y1, double z1, double x2,
double y2, double z2)
{
    double A = x2-x1;
    double B = y2-y1;
    double C = z2-z1;
    double quad = Math.Sqrt(A*A+B*B+C*C);
    return quad;
}
Console.WriteLine("Input a x1 ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a z1 ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a x2 ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a z2 ");
int z2 = Convert.ToInt32(Console.ReadLine());

double resault = Math.Round((FindLenght(x1, y1, z1, x2, y2, z2 )), 3);
Console.WriteLine(resault);
*/
/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
/*
void Cube (int N)
{
    int index = 1;
    while(index <=N)
    {
        Console.Write(index * index * index + " ");
        index++;
    }
}
Console.WriteLine("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());
Cube(N);
*/