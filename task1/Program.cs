Console.WriteLine("Введите 3 слова любой длины");
Console.WriteLine("первое слово: ");
string a = Convert.ToString(Console.ReadLine());
Console.WriteLine("второе слово: ");
string b = Convert.ToString(Console.ReadLine());
Console.WriteLine("третье слово: ");
string c = Convert.ToString(Console.ReadLine());

string[] array = new string[] { a, b, c };
int size = Counter(array);
string[] newArray = ConvertArray(array, size);
Console.WriteLine("[{0}]", string.Join(", ", newArray));

int Counter(string[] arr)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length < 4)
        {
            count++;
        }
    return count;
}

string[] ConvertArray(string[] arr, int size)
{
    string[] newArray = new string[size];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}
