// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число:");
int A = Convert.ToInt32(Console.ReadLine());
string aStr = Convert.ToString(A);
if (A > 99999)
{
    Console.WriteLine("Число введено не верно");
}
else if (aStr[0] == aStr[4] && aStr[1] == aStr[3])
{
    Console.WriteLine("Число является палиндромом");
}
else 
{
    Console.WriteLine("Число не является палиндромом");
}
