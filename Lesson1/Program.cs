// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное  число: ");

int palindrom = Convert.ToInt32 (Console.ReadLine());
  int i1= Math.Abs(palindrom/10000);
  int i5= Math.Abs(palindrom%10);
  int i2 =Math.Abs(palindrom/1000%10);
  int i4 =Math.Abs(palindrom/10%10);

if (Math.Abs(palindrom) > 99999 || Math.Abs(palindrom) < 10000)
{
  Console.Write("Вы ввели не пятизначное число, попробуйте еще раз");
}
else
{
if (i1==i5 && i2==i4)
{
 Console.Write("Число является палиндромом ");
}
else 
{
  Console.Write("Число не является палиндромом");
}
}