// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();

int arraySize = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");
string[] myArray = new string[arraySize];
FillArrayByUser(myArray);

Console.WriteLine($"[“{String.Join("”, “", myArray) + "”"}] -> [“{String.Join("”, “", GetShortArray(myArray)) + "”"}]");

//////////////////////////////////////////////////////////////////////////////////
// Метод для получения массива из строк, длина которых меньше, либо равна 3 символам
//////////////////////////////////////////////////////////////////////////////////
static string[] GetShortArray(string[] inArray)
{
    int size = inArray.Length;
    int count = 0;

    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= 3) count++;
    }

    string[] newArray = new string[count];
    count = 0;

    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= 3)
        {
            newArray[count] = inArray[i];
            count++;
        }
    }
    return newArray;
}

//////////////////////////////////////////////////////////////////////////////////
// Метод для ввода целого числа от пользователя
//////////////////////////////////////////////////////////////////////////////////
static int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

//////////////////////////////////////////////////////////////////////////////////
// Метод заполнения строкового массива пользователем
//////////////////////////////////////////////////////////////////////////////////
static void FillArrayByUser(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива {i}: ");
        array[i] = Console.ReadLine();
    }
}