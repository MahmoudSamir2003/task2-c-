using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
{
    static void Main()
    {
        int[] myArray = new int[] { 10, 5, 3, 6 ,50 ,20 ,15 ,16 ,18 ,19 ,20 ,32 ,50 ,66 ,12 };
        Console.WriteLine("Unsorted Array:");
        PrintArray(myArray);

        // Calling the sort function
        MyCustomSort(myArray);

        Console.WriteLine("\nSorted Array:");
        PrintArray(myArray);
    }

    static void MyCustomSort(int[] x)
    {
        int n = x.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (x[i] > x[j])
                {
                    int temp = x[i];
                    x[i] = x[j];
                    x[j] = temp;
                }
            }
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
    }
}
}
