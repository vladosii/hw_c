//Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).

string s_a = Console.ReadLine()!;

int a = int.Parse(s_a);

int del = a%2;

if (del == 0) {
    Console.WriteLine ($"Число {a} четное!");
}else{
    Console.WriteLine ($"Число {a} НЕ четное!");
}

//Console.WriteLine($"Число {del}");