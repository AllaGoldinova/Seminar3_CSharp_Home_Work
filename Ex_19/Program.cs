// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом
// 14212 -> нет
// 23432 -> да
// 12821 -> да

string number = ReadLine("Введите пятизначное число: ");
if (Convert.ToInt32(number) > 9999 && Convert.ToInt32(number) < 100000)
{
    if (number[4] == number[0] && number[3] == number[1])
    {
        Console.WriteLine($"Число {number} палиндром");
    }
    else
    {
        Console.WriteLine($"Число {number} не палиндром");
    }
}
else
{
    Console.WriteLine("Введено не пятзначное число");
}

string ReadLine(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

