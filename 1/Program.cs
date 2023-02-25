// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна трём символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();
Console.Write("Введите количество строк массива: ");
int stringCount = Convert.ToInt32(Console.ReadLine());
string[] ArrString = new string [stringCount];
for (int i = 0; i <ArrString.Length; i++)
{
    Console.Write($"Введите строку под индексом {i}: ");
    ArrString[i] = Convert.ToString(Console.ReadLine());
}
Console.WriteLine($"\nИзначальный масссив строк: [{string.Join(", ", ArrString)}]");

int ilength = 3;
int CheckArr (string[] array, int ilength)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= ilength) result++;
    }
    return result;
}

int elements = CheckArr (ArrString, ilength);
string[] newArrString = new string [elements];
NewArray (ArrString, newArrString, ilength);

void NewArray(string[] oldArray, string[] newArray, int lengthLimit)
{
    int temp = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= lengthLimit)
        {
            newArray[temp] = oldArray[i];
            temp++;
        }
    }
}
string PrintArray(string[] array)
{
    string result = string.Empty;
    result = "[ ";
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i],1}";
        if (i < array.Length - 1) result += ", ";
    }
    result += " ]";
    return result;
}

Console.Write("\nМассив из 1-, 2- или 3-значных элементов:");
Console.Write($"{PrintArray(newArrString)}");