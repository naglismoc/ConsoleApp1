using System;

namespace functions;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        sayHi();
        sayHiTo("Naglis");
        sayHiTo("Zilvinas");
        string vardas = "Ausra";
        sayHiTo(vardas);
        sayHiToThen("vakaras", "Mindaugai");
        double PIVal = simPI();
        double ray = 64.6;
        Console.WriteLine("apskritimo plotas " + ray * ray * PIVal);
        Console.WriteLine("tikslus apskritimo plotas " + ray * ray * Math.PI);
        double PIVal2 = 3.14;
        string name = "nAGLIS";
        string formatedName = nameFormat(name);
        Console.WriteLine(formatedName);

        int[] numbers = { 5, 65, 6485, 6561, 1, 384, 5615, 05, 135, 615, 651, 51, 135 };
        int[] arraySorted = sortArray(numbers, false);
        for (int i = 0; i < arraySorted.Length; i++)
        {
            Console.Write(arraySorted[i] + " ");
        }
        Console.WriteLine();
    }

    public static int[] sortArray(int[] arr, bool asc)
    {
        for (int i = 0; i < arr.Length; i++)// 0;       0   0   0   0   0
        {
            for (int a = i; a < arr.Length; a++) //0;   1   2   3   4   5
            {
                if (asc)
                {
                    if (arr[i] > arr[a])
                    {
                        int temp = arr[i];
                        arr[i] = arr[a];
                        arr[a] = temp;
                    }
                }
                else
                {
                    if (arr[i] < arr[a])
                    {
                        int temp = arr[i];
                        arr[i] = arr[a];
                        arr[a] = temp;
                    }
                }
            }
        }
        return arr;
    }
    public static string nameFormat(string name)
    {
        if (name.Length <= 1)
        {
            return name.ToUpper();
        }
        return name[0].ToString().ToUpper() + name.Substring(1).ToLower();
    }
    public static double simPI()
    {
        return (float)Math.PI;
    }


    public static void sayHi()
    {
        Console.WriteLine("hi");
    }

    public static void sayHiTo(string name)
    {
        Console.WriteLine($"hi {name}");
    }
    public static void sayHiToThen(string when, string name)
    {
        Console.WriteLine($"labas {when} {name}");
    }
}
