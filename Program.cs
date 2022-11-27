// Задача: Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []



// string[] array = new string[] { "hello", "2", "world", ":-)" };
// string[] array = new string[] {"1234", "1567", "-2", "computer science"};
// string[] array = new string[] {"Russia", "Denmark", "Kazan"};

int lengthOfArray = InputLengthOfArray();
string[] array = FillArray(lengthOfArray);
int lengthArrayToFill = FindLengthArrayToFill(array);
string[] resultArray = MakeArrayOf1To3Symbol(array);

PrintArray(array);
Console.Write(" -> ");
PrintArray(resultArray);
Console.WriteLine();
Console.WriteLine();


int FindLengthArrayToFill(string[] arr)
{
    int counterElement = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (array[i].Length <= 3) counterElement = counterElement + 1;
    }
    return counterElement;
}


string[] MakeArrayOf1To3Symbol(string[] arr)
{
    string[] arrayOf1To3Symbol = new string[lengthArrayToFill];

    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            arrayOf1To3Symbol[j] = arr[i];
            j++;
        }
    }
    return arrayOf1To3Symbol;
}


void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write($"\"{arr[i]}\", ");
        }
        else
        {
            Console.Write($"\"{arr[i]}\"");
        }

    }
    Console.Write("]");
}


string[] FillArray(int length)
{
    string[] arr = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите элемент массива №{i + 1}: ");
        arr[i] = Console.ReadLine();
    }
    Console.WriteLine();
    return arr;
}

int InputLengthOfArray()
{
    Console.WriteLine();
    Console.Write("Введите длину исходного массива: ");
    int lengthOfArr = Convert.ToInt32(Console.ReadLine());
    while (lengthOfArr < 0)
    {
        Console.Write("Введите натурально число, либо 0: ");
        lengthOfArr = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return lengthOfArr;
}