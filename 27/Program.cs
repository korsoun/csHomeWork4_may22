// Задача 27
// Принять число и вывести сумму его цифр

int SumOfDigits (int number)  // метод для нахождения суммы цифр
{
    int sum = 0;
    while(number > 0) 
    {
        sum = sum + (number % 10);      // отщипываем от числа по одной цифре, прибавляя его к сумме, пока не сведем число к нулю
        number = number / 10;
    }
    return sum;
}

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"Сумма цифр числа {number} равна {SumOfDigits(number)}");