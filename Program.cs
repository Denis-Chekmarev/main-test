
string[] clipping(string[] arr, int numb)
{
    string[] result = new String[arr.Length];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= numb)
        {
            result[j] = arr[i];
            j++;
        }
    }
    return result;
}

void printArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int number = 3;
string[] inputArr = { "Moscow", "Add", "Check", "-2", "ytn", "input", "33" };
string[] result = clipping(inputArr, number);
printArr(result);