using System;
using System.Text;

public static class ArrayExtension
{
    private static (int, int) asciiInterval = (40, 127);

    public static string[] GenerateRandomStrings(this string[] array, int minElementLength, int maxElementLength)
    {
        var rnd = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            var j = rnd.Next(minElementLength, maxElementLength + 1);
            StringBuilder sb = new StringBuilder(j);
            for (int k = 0; k <= j; k++)
            {
                var chr = rnd.Next(asciiInterval.Item1, asciiInterval.Item2 + 1);
                sb.Append((char)chr);
            }

            array[i] = sb.ToString();
        }
        return array;
    }

    public static void PrintArrayToConsole(this string[] array) =>
        Console.WriteLine(WriteAsString(array));
    

    private static string WriteAsString(string[] arr)
    {
        if (arr.Length == 0) return "[]";
        if (arr.Length == 1) return $"[{arr[0]}]";
        
        StringBuilder sb = new StringBuilder($"[\"{arr[0]}\"");
        for (int i = 1; i < arr.Length; i++)
        {
            sb.Append($" ,\"{arr[i]}\"");
        }

        sb.Append("]");
        return sb.ToString();
    }
}
