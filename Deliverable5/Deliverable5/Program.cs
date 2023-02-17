using System;

class Program
{
    static void Main(string[] args)
    {
        int arrayLength = 0;

        try
        {
            Console.Write("Enter a number between 5 and 15: ");
            arrayLength = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

        if (arrayLength < 5 || arrayLength > 15)
        {
            Console.WriteLine("Invalid input. Please enter a number between 5 and 15.");
            return;
        }

        int[] numbers = PopulateArray(arrayLength);
        Console.WriteLine("Elements in the array:");
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("{0} ", numbers[i]);
        }
        Console.WriteLine();

        int sum = GetArraySum(numbers);
        Console.WriteLine("Sum of the elements in the array: {0}", sum);
    }

    static int[] PopulateArray(int length)
    {
        int[] array = new int[length];
        Random rand = new Random();

        for (int i = 0; i < length; i++)
        {
            array[i] = rand.Next(10, 51);
        }

        return array;
    }

    static int GetArraySum(int[] array)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }
}