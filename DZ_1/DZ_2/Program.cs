/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
 Console.WriteLine("Введите три числа");

string namberStr = Console.ReadLine();
string namberStr1 = Console.ReadLine();
string namberStr2 = Console.ReadLine();


int namber1 = int.Parse(namberStr);
int namber2 = int.Parse(namberStr1);
int namber3 = int.Parse(namberStr2);

int max = namber1;

if(namber2 > max)
{
    max = namber2;
}
else
{
    max = max;
}

if(namber3 > max)
{
    max = namber3;
}
else
{
    max = max;
}

Console.WriteLine($"Наибольшее число {max}");
