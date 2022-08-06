// Задача: написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string [] specifiedArray = {"Hello", "one", "World", ":-)", "Привет!", "two", "три"};
Console.WriteLine("Наш заданный массив: ");
PrintArray(specifiedArray);

int count = 3; // можно менять искомое количество символов на старте (через ввод с консоли, например) 

string[] newArray = new string [specifiedArray.Length]; // создаем второй массив string по условию задачи
for (int i=0; i < specifiedArray.Length; i++)
     {      
        if(specifiedArray[i].Length <= count) newArray[i] = specifiedArray[i];
     }

Console.WriteLine();
Console.WriteLine("Измененный массив с элементами не более трёх символов: ");
PrintArray(newArray);


void PrintArray(string [] Array) // создаем Метод void для печати (используется несколько раз)
{
    Console.Write("[ ");
    for (int i=0; i<Array.Length; i++)
    {
        if (Array [i] != null)
        if (i == Array.Length-1) Console.Write($"\"{Array[i]}\"");
        else Console.Write($"\"{Array[i]}\", ");
    }
    Console.Write(" ] ");
    Console.WriteLine();
}

