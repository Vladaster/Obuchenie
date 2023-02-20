/*Console.Write("Напишите число возводимое в квадрат - ");
int numb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ответ - {numb * numb}"); */

/*
Console.Write("Введите первое чило - ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе чило - ");
int B = Convert.ToInt32(Console.ReadLine());

if(B * B == A)
{
    Console.WriteLine("Первое число является квадратом второго");

}
else
{
    Console.WriteLine("Число не является квадратом второго");
} */


/*
Console.Clear();
Console.Write("Введите число - ");
int a = Convert.ToInt32(Console.ReadLine());
if( a == 1)
{
    Console.WriteLine("Понедельник");
}
if( a == 2)
{
    Console.WriteLine("Вторник");
}
if( a == 3)
{
    Console.WriteLine("Среда");
}
if( a == 4)
{
    Console.WriteLine("Четверг");
}
if( a == 5)
{
    Console.WriteLine("Пятница");
}
if( a == 6)
{
    Console.WriteLine("Суббота");
}
if( a == 7)
{
    Console.WriteLine("Восскресенье");
}
if(a > 7)
{
    Console.Write("Вы ввели неправильное значение");
} */


/*
Console.WriteLine("Введите число - ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Random.Next(-N, N));
*/

Console.Write("Введите трехзначное число");
int a = int.Parse(Console.ReadLine());
int x= a%10;
Console.WriteLine(x);