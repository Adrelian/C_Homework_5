// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// void findAllEvenInteger(int size)
// {
//     // Созадние массива с трёхзначными числами размера size (от пользователя)
//     int[] myArray = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(100,1000);
//     }
    
//     // Отображение массива на экране
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"{myArray[i] + ", "}");
//     }
//     Console.WriteLine();

//     // поиск и сложение чётных чисел
//     int counter = 0; // счётчик чисел
//     for (int i = 0; i < myArray.Length; i++)
//     {
//         if (myArray[i] % 2 ==0) counter++;
//     }

//     Console.WriteLine($"Кол-во чётных чисел в массиве {counter}");
// }
// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// findAllEvenInteger(size);



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// void findSumNumberOnOddPosition()
// {
//     // Создаём массив из случайных и случайного размера

//     //Задаём случайны размер
//     int size = new Random().Next(5, 10); 
//     int [] myArray = new int [size];

//     // Задаём массив
//     Console.Write("Массив -> ");
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(1, 100);
//     }
    
//     // Отображаем массив
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($" {myArray[i] + ", "} ");
//     }
//     Console.WriteLine();

//     // Сумма элементов на позициях
//     int sumOdd = 0; // Сумма на чётных позициях
//     int sumNotOdd = 0; // Сумма на нечётных элементов
//     for (int i = 1; i < size; i++) // Счёт начинаем с позиции 1
//     {
//         if (i % 2 == 0)
//         {
//             sumOdd += myArray[i]; // сумма четных
//         }
//         sumNotOdd += myArray[i]; // сумма нечетных чисел


//     }
//     Console.WriteLine($"Сумма чётных элементов {sumOdd} и нечётных элементов {sumNotOdd}");
// }
// findSumNumberOnOddPosition();


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] CreatArray()
{
    // Создаём массив из случайных и случайного размера

    //Задаём случайны размер
    int size = new Random().Next(5, 10); 
    int [] myArray = new int [size];

    // Задаём массив
    Console.Write("Массив -> ");
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(-100, 100);
    }
    
    // Отображаем массив
    for (int i = 0; i < size; i++)
    {
        Console.Write($" {myArray[i] + ","}");
    }
    Console.WriteLine();
    return myArray;   
}

void findSubstractionMinAndMaxNumberInArray(int[] array)
{
    // ищем максимальное и минмальное число
    int max = 0;
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    int subtraction = max - min; // разница
    // Если Min меньше 0, то в выводе ставим скобки
    if (min < 0) Console.WriteLine($"{max} - ({min}) = {subtraction}");
    if (min >= 0) Console.WriteLine($"{max} - {min} = {subtraction}");
}

findSubstractionMinAndMaxNumberInArray(CreatArray());