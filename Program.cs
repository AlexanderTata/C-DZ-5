void Zadacha34()
{   
    //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
    //Напишите программу, которая покажет количество чётных чисел в массиве.

    int size = 8;
    int[] array = new int[size]; //добавляем переменную size для универсальности программы 
    FillArray(array, 100, 999);
    PrintArray(array);
    KolChetnykhChisel(array);
}
void  KolChetnykhChisel(int[] array)
{
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

void Zadacha36()
{
    //Задача 36: Задайте одномерный массив, заполненный случайными числами. 
    //Найдите сумму элементов, стоящих на нечётных позициях.
    // в данной задачи, считаем по нечетным индексам 
    int size = 8;
    int[] array = new int[size]; 
    FillArray(array, 0, 10);
    PrintArray(array);

    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sum += array[i];
    }

    Console.WriteLine("сумма элементов стоящих на нечётных позициях равна: " + sum  );

}

void Zadacha38()
{
    //Задача 38: Задайте массив вещественных чисел. 
    //Найдите разницу между максимальным и минимальным элементов массива.

    Random random = new Random();
    double[] array = new double[10];

    for (int i = 0; i < array.Length; i++)
    {
        array[1] = random.NextDouble();
    }

    Console.WriteLine("Вывод массива ");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t" );
    }

    Console.WriteLine();


}
//Zadacha34();
//Zadacha36();
Zadacha38();
