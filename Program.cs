// Задача: Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []



string[] array = new string[] { "hello", "2", "world", ":-)" };
// string[] array = new string[] {"1234", "1567", "-2", "computer science"};
// string[] array = new string[] {"Russia", "Denmark", "Kazan"};



int lengthArrayToFill = FindLengthArrayToFill(array);
string[] resultArray = MakeArrayOf1To3Symbol(array);
PrintArray(array);
Console.WriteLine();
PrintArray(resultArray);



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
            Console.Write($"{arr[i]}\", ");
        }
        else
        {
            Console.Write($"{arr[i]}\"]");
        }
    }
}