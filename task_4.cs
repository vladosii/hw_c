//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

string s_a = Console.ReadLine()!;

int a = int.Parse(s_a);

for (int i = 1; i < a+1; i++)
{
    if (i%2 == 0){
        Console.WriteLine(i);
    }
}