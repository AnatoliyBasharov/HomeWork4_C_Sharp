// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int number = ReadInt("Введите число ");
Char[] array = number.ToString().ToCharArray();
int index = 0;
int sum = 0;
while (index < array.Length-1)
{
    sum = sum+ array[0];
    index++;
    System.Console.Write(sum);
}