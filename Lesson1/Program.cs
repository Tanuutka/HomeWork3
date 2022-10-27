void Zadacha19()
{

    // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    Console.Write("Введите пятизначное  число: ");

    int number = Convert.ToInt32(Console.ReadLine());
    int i1 = Math.Abs(number / 10000);
    int i5 = Math.Abs(number % 10);
    int i2 = Math.Abs(number / 1000 % 10);
    int i4 = Math.Abs(number / 10 % 10);
    Palindrom(number, i1, i2, i4, i5);
}
void Palindrom(int number, int i1, int i2, int i4, int i5)
{

    if (Math.Abs(number) > 99999 || Math.Abs(number) < 10000)
    {
        Console.Write("Вы ввели не пятизначное число, попробуйте еще раз");
    }
    else
    {
        if (i1 == i5 && i2 == i4)
        {
            Console.Write("Число является палиндромом ");
        }
        else
        {
            Console.Write("Число не является палиндромом");
        }
    }
}

Zadacha19();