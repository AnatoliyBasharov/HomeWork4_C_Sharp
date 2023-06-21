// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int numberOne = ReadInt("Введите число ");
int numberTwo = ReadInt("Введите второе число ");
int sum = 1;
int temp = numberOne;
while (numberTwo > sum)
{
    temp *= numberOne;
    sum++;
}
System.Console.WriteLine(temp);