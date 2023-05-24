// Задача 1 (34). Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.WriteLine("Введите размер массива: ");
int array_size = Convert.ToInt32(Console.ReadLine());
int[] userArray = CreateRandomArray(array_size, 100, 999);
PrintArray(userArray);
Console.WriteLine($"Количество четных чисел в массиве равняется {FindEvenNum(userArray)}");

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int index = 0; index < size; index++){newArray[index] = new Random().Next(minValue, maxValue + 1);}
    return newArray;
}

void PrintArray(int[] arrayExample)
{
    int size = arrayExample.Length;
    for(int index = 0; index < size; index++){Console.Write(arrayExample[index] + " ");}
    Console.WriteLine();
}

int FindEvenNum(int[] array)
{
    int countEvenNum = 0;
    for(int i = 0; i < array.Length; i++) if (array[i]%2 == 0) countEvenNum++;
    return countEvenNum;
}

// Задача 2 (36). Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.WriteLine("Введите размер массива: ");
int array_size1 = Convert.ToInt32(Console.ReadLine());
int[] userArray1 = CreateRandomArray1(array_size1, -99, 99);
PrintArray1(userArray1);
Console.WriteLine($"Сумма элементов на начетных позициях в массиве равняется {FindOddNumSum(userArray1)}");

int[] CreateRandomArray1(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int index = 0; index < size; index++){newArray[index] = new Random().Next(minValue, maxValue + 1);}
    return newArray;
}

void PrintArray1(int[] arrayExample)
{
    int size = arrayExample.Length;
    for(int index = 0; index < size; index++){Console.Write(arrayExample[index] + " ");}
    Console.WriteLine();
}

int FindOddNumSum(int[] array)
{
    int oddNumSum = 0;
    for(int i = 0; i < array.Length; i++) if (i%2 == 1) oddNumSum = oddNumSum + array[i];
    return oddNumSum;
}

// Задача 3 (38). Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.WriteLine("Введите размер массива: ");
int array_size2 = Convert.ToInt32(Console.ReadLine());
double[] userArray2 = CreateRandomArray2(array_size2);
PrintArray2(userArray2);
Console.WriteLine($"Разница между макисмальным и минимальным элементами массива равняется {FindMaxValue(userArray2) - FindMinValue(userArray2)}");

double[] CreateRandomArray2(int size)
{
    double[] newArray = new double[size];
    for(int index = 0; index < size; index++){newArray[index] = (new Random().NextDouble()) + (new Random().Next(0, 100));}
    return newArray;
}

void PrintArray2(double[] arrayExample)
{
    int size = arrayExample.Length;
    for(int index = 0; index < size; index++){Console.Write(arrayExample[index] + " ");}
    Console.WriteLine();
}

double FindMaxValue(double[] array)
{
    double maxValue = array[0];
    for(int i = 0; i < array.Length; i++) if (array[i] > maxValue) maxValue = array[i];
    return maxValue;
}

double FindMinValue(double[] array)
{
    double minValue = array[0];
    for(int i = 0; i < array.Length; i++) if (array[i] < minValue) minValue = array[i];
    return minValue;
}