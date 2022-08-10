Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");

var num = 0;
var str = "";

while(true) {
Console.WriteLine("Введите трёхзначное число: ");
str = Console.ReadLine();
if(int.TryParse(str, out int number)) {
    num = number;
    if(str.Length == 3) {
        break;
    }
    else Console.WriteLine("Введено НЕ трёхзначное число!");
}
else Console.WriteLine("Некорректно введено число!");
}

Console.WriteLine("Вторая цифра числа " + num + ": " + str[1]);
