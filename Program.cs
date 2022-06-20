Console.Write("Введите количество элементов массива строк:\t");
int elementCount = Convert.ToInt32(Console.ReadLine());
string[] arrayString = Create(elementCount);
Fill(arrayString);
Console.WriteLine(Print(Change(arrayString)));

string[] Create(int size)
{
    return new string[size];
}

void Fill(string[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите элемент {i + 1}:  ");
        array[i] = Console.ReadLine();
    }
}

string Print(string[] array)
{
    string result = string.Empty;
    int size = array.Length;
    result = "[";
    for (int i = 0; i < size; i++)
    {
        if (array[i] != string.Empty)
        {
            result += $" {array[i]} ";
        }
        
    }
    result += "]";

    return result;
}

string[] Change(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length > 3)
        {
            array[i] = string.Empty;
        }
    }
    return array;
}