// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучшеstring[] array1 = new string[5] {"123", "23", "hello", "world", "res"};

string[] CreateArray(int size)
{
    string[] result = new string[size];
    int num = 0;

    if (num < size)
    {
        num++;
    }
    return result;
}

string[] FillArray(string[] arrayOne)
{
    for (int i = 0; i < arrayOne.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент: ");
        arrayOne[i] = Console.ReadLine();
    }
    return arrayOne;
}

int SelectionArray(string[] select)
{
    int count = 0;
    for (int i = 0; i < select.Length; i++)
    {
        if (select[i].Length <= 3)
            count++;
    }
    return count;
}

string[] OutputArray(string[] selectArray, string[] arrayTwo)
{
    int j = 0;

    for (int i = 0; i < selectArray.Length; i++)
    {
        if (selectArray[i].Length <= 3)
        {
            arrayTwo[j] = selectArray[i];
            j++;
        }
    }
    return arrayTwo;
}

Console.Write("Введите размер массива: ");
int number = int.Parse(Console.ReadLine());

string[] array = CreateArray(number);
FillArray(array);
int index = SelectionArray(array);
string[] NewArray = CreateArray(index);
OutputArray(array, NewArray);

if (NewArray.Length == 0)
{
    Console.WriteLine("Массив не сформерован, так как длина строк больше 3-х");
}
else
{
    Console.WriteLine("Получившийся массив: ");
    Console.Write($"[{String.Join(", ", NewArray)}]");
}
