//=======================================================
// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с
// клавиатуры, либо задать на старте выполнения алгоритма. При решении не
// рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//=======================================================

// Метод считывания данных пользователя
string ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем и возвращаем строку
    return Console.ReadLine() ?? "";
}

// Метод считывания элементов массива строк заданной длины от пользователя
string[] ReadArray(int elementQuantity)
{
    string[] inputArr = new string[elementQuantity];

    // В цикле запрашиваем очередной элемент массива
    for (int i = 0; i < elementQuantity; i++)
    {
        inputArr[i] = ReadData($"Введите {i + 1}-й элемент массива: ");
    }

    return inputArr;
}

// Метод, печатает одномерный массив строк
void PrintStringArray(string[] arr)
{
    string arrString = "[";

    // В цикле накапливаем в строку элементы массива через запятую и в кавычках
    for (int i = 0; i < arr.Length - 1; i++)
    {
        arrString += $"\"{arr[i]}\", ";
    }

    // Завершаем строку последним элементом если он есть
    arrString += arr.Length > 0 ? $"\"{arr[arr.Length - 1]}\"]" : "]";
    Console.WriteLine(arrString);
}

// Метод, принимает массив строк и максимальное количество символов, возвращает новый отфильтрованный массив
string[] FilterArray(string[] arr, int max)
{
    string[] filteredArr = new string[arr.Length];
    int matchedElements = 0; // Счётчик подходящих под фильтр элементов
    // В цикле проверяем каждый элемент на количество символов и сохраняем в новый массив
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= max)
        {
            filteredArr[matchedElements] = arr[i];
            matchedElements++;
        }
    }
    // Уменьшаем новый массив, отсекая пустые элементы
    Array.Resize(ref filteredArr, matchedElements);
    return filteredArr;
}

int maxSymbols = 3;

// Получаем количество элементов массива от пользователя
int symbolQuantity = 0;
string inputQuantity = ReadData("Введите количество элементов будущего массива: ");

// Проверяем введенное число на текст, выполняем задачу
if (int.TryParse(inputQuantity, out symbolQuantity) && symbolQuantity >= 0)
{
    string[] inputArray = ReadArray(symbolQuantity);
    Console.WriteLine("Изначальный массив строк:");
    PrintStringArray(inputArray);

    Console.WriteLine($"Массив строк с фильтром не более {maxSymbols} символов:");
    PrintStringArray(FilterArray(inputArray, maxSymbols));
}
else
{
    Console.WriteLine("Неверно введена длина массива");
}