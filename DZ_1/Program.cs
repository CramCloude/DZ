/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Введите 2 числа");
string namberStr = Console.ReadLine();
string namberStr1 = Console.ReadLine();

int namber1 = int.Parse(namberStr);
int namber2 = int.Parse(namberStr1);

if(namber1 > namber2)
{
Console.WriteLine($"Наибольшее из двух чисел {namber1} Наименьшее {namber2}");
}

else
{
    Console.WriteLine($"Наибольшее число из двух {namber2} Наименьшее {namber1}");
}