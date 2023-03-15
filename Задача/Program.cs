// Напишите программу, которая из имеющегося массива строк формирует массив строк, 
// длина которых меньше либо равна 3 символа
// Первоначальный массив можно ввести с клавиатурыы, либо задать на старте выполнения алгоритма.

Console.Clear();

string[] Array(string[] array)
{
    int index = 0;
    string[] rezult = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            rezult[index] = array[i];
            index++;
        }
    }
    return rezult;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] Getarray = { "<3", "wish", "you", "best" };
string[] newArray = Array(Getarray);
PrintArray(newArray);