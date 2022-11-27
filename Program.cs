// Задача: Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

//           СДЕЛАТЬ МЕТОДАМИ

// string[] array = new string[] {"hello", "2", "world", ":-)"};
// string[] array = new string[] {"1234", "1567", "-2", "computer science"};
string[] array = new string[] {"Russia", "Denmark", "Kazan"};

int counterElement = default;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) counterElement = counterElement + 1; 
}

// Console.WriteLine(counterElement);
// Console.WriteLine();

string[] arrayOf1To3Symbol = new string[counterElement];

// for (int i = 0; i < arrayOf1To3Symbol.Length; i++)
// {
//    Console.WriteLine($"[{arrayOf1To3Symbol[i]}]");
// }

int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        arrayOf1To3Symbol[j] = array[i];
        j++;
    }
}

for (int i = 0; i < arrayOf1To3Symbol.Length; i++)
{
   Console.WriteLine($"[{arrayOf1To3Symbol[i]}]");
}