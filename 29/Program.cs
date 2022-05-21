// Задача 29
// принять число, обозначающее длину массива, и вывести массив заданной длины из случайных цифр

Console.Write("Какой длины будет массив? ");
int lenght = Convert.ToInt32(Console.ReadLine());

int[] userArray = new int[lenght];  // создан массив, выделено место под нужное количество элементов

void CreateArray(int[] userArray, int lenght)  // метод для заполнения массива
{
    for (int i = 0; i < lenght; i++)
    {
        Random arrayValues = new Random();
        userArray[i] = arrayValues.Next(100); // пусть будут числа от 0 до 99
    }
    
}

void OutputArray(int[] userArray, int lenght)  // метод для вывода массива
{
    for(int i = 0; i < lenght; i++)
    {
        Console.Write(userArray[i]);
        Console.Write(" ");
    }
    
}

Console.Write("Созданный массив: ");
CreateArray(userArray, lenght);
OutputArray(userArray, lenght);
