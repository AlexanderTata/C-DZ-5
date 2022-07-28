void Zadacha34()
{   
    //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
    //Напишите программу, которая покажет количество чётных чисел в массиве.

    int size = 8;
    int[] array = new int[size]; //добавляем переменную size для универсальности программы 
    FillArray(array, 100, 999);
    PrintArray(array);

    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count ++;
    }

    Console.WriteLine("Количество чётных чисел в заданом массиве равно " + count);
    
}

void FillArray(int[] array, int startNumber = 0, int finishNumber = 1)
{
    finishNumber ++;
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startNumber, finishNumber);
    }
    
}   

void PrintArray(int[] array)
{   
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t" );
    }

    Console.WriteLine();

}  


void Zadacha27()
{   
    //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

    Random random = new Random();
    int number = random.Next(333, 777);

    SumOfDigit(number);

}

void SumOfDigit(int number)
{
    int sum = 0;

    Console.Write("В числе " + number);

    while(number > 0)
    {
        sum += number % 10;
        number /= 10;
    }

    Console.WriteLine(" сумма цифр равна: " + sum);

}

void Zadacha29()
{
    //Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит 
    //отсортированный по модулю массив

    int size = 8;
    int[] array = new int[size];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-10, 11);
    }

    Console.WriteLine();
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();

    for (int i = array.Length - 1; i > 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if (Math.Abs(array[j]) > Math.Abs(array[j + 1]))
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}

Zadacha34();
//Zadacha27();
//Zadacha29();
