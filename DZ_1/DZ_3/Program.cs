/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/
Console.WriteLine("Введите число");

string namberStr = Console.ReadLine();
int namber = int.Parse(namberStr);

if(namber %2==1)
{
    Console.WriteLine("Число нечётное");
}
else
{
    Console.WriteLine("Число четное");
}