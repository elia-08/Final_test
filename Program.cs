class Program
{
    static int MaxWordLength = 3;
    public static void Main()
    {
        string[] array1 = {"Привет", "!", "массив", "123"};
        string[] array2 = {"Африка", "США", "Рим"};
        string[] array3 = {"435672", "1", ":-)"};

        ShowTask(array1);
        ShowTask(array2);
        ShowTask(array3);
    }

    static string[] ShortWordsArray(string[] array)
    {
        int length = array.Length;
        string[] result = new string[length];
        int count = 0;
        for (int i = 0; i < length; i++)
        {
            if (array[i].Length <= MaxWordLength)
            {
                result[count] = array[i];
                count++;
            }
        }
        
        Array.Resize(ref result, count);
        return result;
    }
     
    static void ShowArray(string[] array)
    {
        if (array.Length == 0)
        {
            Console.Write("Массив пуст");
        }
        else 
        {
            Array.ForEach(array, (str) => Console.WriteLine($"{str}"));
            Console.WriteLine();
        }
    }
     
    static void ShowTask(string[] array)
    {
        Console.WriteLine("Исходный массив:");
        ShowArray(array);
        string[] shortArray = ShortWordsArray(array);
        Console.WriteLine($"Сокращенный массив:");
        ShowArray(shortArray);
        Console.WriteLine();
    }
}
  
