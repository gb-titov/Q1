// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// Использовать исключительно массивы.

using Q1;
using c = System.Console;

int arrLength =8, 
    maxStringSize = 5, 
    minStringSize = 1,
    maxNewStringSize = 3;

c.WriteLine("Генерируем новый массив...");
var array = new string[arrLength].GenerateRandomStrings(minStringSize, maxStringSize);
c.WriteLine("Сгенерированный массив:");
array.PrintArrayToConsole();
c.WriteLine($"Формирую новый массив с размером элементов не более {maxNewStringSize}:");
var newArray = new ArrayService().GetStrings(array, maxNewStringSize);
newArray.PrintArrayToConsole();





