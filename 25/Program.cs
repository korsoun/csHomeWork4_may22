// Задача 25
// Принять числа А и В и возвести А в степень В, не пользуясь стандартными методами

int Exponentiation (int baseNum, int degree)    // метод для возведения в степень
{
    int raisedNumber = baseNum;
    int count = 0;
    while(count < degree - 1)          // цикл для возведения в степень. Для второй степени число нужно умножить на себя 1 раз, для третьей - 2 раза и т.д
    {
        raisedNumber = raisedNumber * baseNum;
        count++;
    }
    return raisedNumber;   // по условию степень натуральная, поэтому отдельного действия для нулевой степени нет
}

Console.WriteLine("Введите последовательно целое число и степень для возведения (степень в виде натурального числа): ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int result = Exponentiation(a, b);
Console.WriteLine($"Число {a} в степени {b} это {result}");