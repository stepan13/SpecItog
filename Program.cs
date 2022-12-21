string[] userArray = FillArray();
string[] resultArray = GetArrayOfShorterElemets(userArray, 3);
PrintStringArray(resultArray);

string[] GetArrayOfShorterElemets(string[] arr, int maxLenght)
{
    int length = arr.Length;
    string[] tempResult = new string[length];
    string elem = string.Empty;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        elem = arr[i];
        if (elem.Length <= maxLenght)
        {
            tempResult[count] = elem;
            count++;
        }
    }

    string[] result = new string[count];
    for (int i = 0; i < count; i++)
    {
        result[i] = tempResult[i];
    }
    return result;
}

string[] FillArray()
{
    string inputString = String.Empty;
    string[] result = { };
    int count = 1;
    do
    {
        System.Console.Write($"Введите {count} строку. Для окончания введите пустую строку:");
        inputString = Console.ReadLine() ?? string.Empty;
        if (inputString != string.Empty)
        {
            Array.Resize(ref result, count);
            result[count - 1] = inputString;
            count++;
        }

    } while (inputString != String.Empty);
    return result;
}

void PrintStringArray(string[] arr)
{
    int length = arr.Length;
    System.Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        Console.Write(arr[i] + (i == length-1 ? "" : ", "));
    }
    System.Console.WriteLine("]");
}