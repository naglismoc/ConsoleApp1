using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP;

internal class Helper
{

    public static string maybe()
    {
        if (1 > 2)
        {
            return "yes";
        }
        return null;
    }

    public static void printArr(int[] arr)
    {
        string res = "";
        for (int i = 0; i < arr.Length; i++)
        {
            res += arr[i] + ", ";
        }
        Console.WriteLine(res.Substring(0, res.Length - 2));
    }
    public static void printArr(string[] arr)
    {
        string res = "";
        for (int i = 0; i < arr.Length; i++)
        {
            res += arr[i] + ", ";
        }
        Console.WriteLine(res.Substring(0, res.Length - 2));
    }
    public static void printArr(bool[] arr)
    {
        string res = "";
        for (int i = 0; i < arr.Length; i++)
        {
            res += arr[i] + ", ";
        }
        Console.WriteLine(res.Substring(0, res.Length - 2));
    }

    public static void printArr(char[] arr)
    {
        string res = "";
        for (int i = 0; i < arr.Length; i++)
        {
            res += arr[i] + ", ";
        }
        Console.WriteLine(res.Substring(0, res.Length - 2));
    }

}

