using System.Text.RegularExpressions;

namespace ConsoleApp1;
internal class Program
{
    static void Main(string[] args)
    {


        Random random = new Random();
        Console.WriteLine("Task 7");
        Console.WriteLine();

        int sparks = random.Next(0, 3000);
        Console.WriteLine("Sparks: " + sparks);
        Console.WriteLine();


        if (sparks <= 1000)
        {
            Console.WriteLine("Sparks price: " + (sparks * 1) + " Eur");
        }

        if (sparks > 1000 && sparks <= 2000)
        {
            Console.WriteLine("Sparks price: " + (sparks * 0.97) + " Eur");
        }

        if (sparks > 2000)
        {
            Console.WriteLine("Spark price: " + (sparks * 0.96) + " Eur");
        }
        Console.WriteLine();
        //string name = "Naglis";
        //string weather = "sninga";
        //int temperature = -7;

        //Console.WriteLine("Sveiki, xx. Šiandien xx, temperatūra xx. Gražios dienos!");
        //Console.WriteLine("Sveiki, " + name + ". Šiandien " + weather + ", temperatūra " + temperature + ". Gražios dienos!");
        //Console.WriteLine($"Sveiki, {name}. Šiandien {weather}, temperatūra {temperature}. Gražios dienos!");
        //Console.WriteLine($"tekstas {Environment.NewLine} is naujos eilutes");
        //int num = 0;
        ////     0  +  1
        //num = num + 1;
        ////     1  +  1
        //num = num + 1;
        ////     2  +  1
        //num = num + 1;

        //num += 1;
        //num++;
        //num--;

        //num = num + 18;
        //num += 18;
        //num++;

        //num -= 5;
        //num *= 4;
        //num /= 3;

        //for (int i = 0; i < 3; i++)
        //{
        //    Console.WriteLine("labas");

        //}


        //for (int i = 0; i < 5; i++)
        //{
        //    Console.WriteLine("i reiksme " + i);
        //}
        ////             01234
        //string word = "labas";
        //Console.WriteLine(word[0]);
        //Console.WriteLine(word[1]);
        //Console.WriteLine(word[2]);
        //Console.WriteLine(word[3]);
        //Console.WriteLine(word[4]);
        //Console.WriteLine("-------------------------");
        //for (int i = 0; i < word.Length; i++)
        //{
        //    Console.WriteLine(word[i]);
        //}

        //for (int i = 0; i < word.Length; i++)
        //{
        //    Console.WriteLine("word[" + i + "] yra " + word[i]);
        //}

        //int skaicius = 17;
        ////                0  1  2
        //int[] skaiciai = [4, 8, 10];
        //Console.WriteLine(skaiciai);
        //Console.WriteLine(skaiciai[0]);
        //Console.WriteLine(skaiciai[1]);
        //Console.WriteLine(skaiciai[2]);

        //int[] skaiciai2 = new int[5];
        //Console.WriteLine(skaiciai2[2]);

        //skaiciai2[0] = 1;
        //skaiciai2[1] = 2;
        //skaiciai2[2] = 3;
        //skaiciai2[3] = 5;
        //skaiciai2[4] = 10;

        //skaiciai2[2] = 4;

        //Console.WriteLine("---------------");
        //for (int i = 0; i < skaiciai2.Length; i++)
        //{
        //    Console.WriteLine(skaiciai2[i]);
        //}
        ////                  0           1         2         3             4
        //string[] names = ["Jonas", "Antanas", "Audrius", "Giedrius", "Jolanta"];
        ////string[] names2 = new string[] { "Jonas", "Antanas", "Audrius", "Giedrius", "Jolanta" };
        ////string[] names3 = new string[5];



        //for (int i = 10; i < 15; i++)
        //{
        //    Console.WriteLine(i);
        //}

        //for (int i = 0; i < 15; i += 2)
        //{
        //    Console.WriteLine(i);
        //}

        //for (int i = 0; i < names.Length; i++)
        //{
        //    Console.WriteLine(names[i]);
        //}
        //Console.WriteLine("-------------");
        //for (int i = names.Length - 1; i >= 0; i--)
        //{
        //    Console.WriteLine(names[i]);
        //}

        //int a = 0;
        //for (; true;)
        //{
        //    Console.WriteLine(a);
        //    a++;
        //    if (a >= 5)
        //    {
        //        break;
        //    }
        //}

        //Random r = new Random();
        //while (true)
        //{
        //    int dice = r.Next(1, 6);
        //    Console.WriteLine("kauliukas " + dice);
        //    if (dice == 1)
        //    {
        //        break;
        //    }
        //}

        //Console.WriteLine("----------");

        //for (int i = 0; i < 10; i++)
        //{
        //    if (i % 2 == 0)
        //    {
        //        continue;
        //    }
        //    Console.WriteLine(i);

        //}
        //Console.WriteLine("----------");


        //for (int i = 0; i < 5; i--)
        //{
        //    Console.WriteLine(i);
        //    if (i <= -20)
        //    {
        //        break;
        //    }
        //}

        //name = Console.ReadLine();
        //Console.WriteLine("tavo vardas " + name);

        //while (true)
        //{
        //    Console.WriteLine("iveskite skaiciu nuo 1 iki 10");
        //    int input = 0;
        //    try
        //    {
        //        input = Convert.ToInt32(Console.ReadLine());
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("prasome paduoti skaiciu skaitmenimis");
        //    }
        //    if (input >= 1 && input <= 10)
        //    {
        //        Console.WriteLine("ačiū, jūs įvedėte " + input);
        //        break;
        //    }
        //    Console.WriteLine("skaicius nepatenka į intervalą");
        //}

        //bool shouldGo = true;

        //while (shouldGo)
        //{
        //    Console.WriteLine("iveskite skaiciu nuo 1 iki 10");
        //    int input = 0;
        //    try
        //    {
        //        input = Convert.ToInt32(Console.ReadLine());
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("prasome paduoti skaiciu skaitmenimis");
        //    }
        //    if (input >= 1 && input <= 10)
        //    {
        //        Console.WriteLine("ačiū, jūs įvedėte " + input);
        //        shouldGo = false;
        //    }
        //    Console.WriteLine("skaicius nepatenka į intervalą");
        //}


        //do
        //{
        //    Console.WriteLine("padarom");
        //} while (false);


        //for (int i = 0; i < names.Length; i++)
        //{
        //    string vardas = names[i];
        //    Console.WriteLine(vardas);
        //}

        //foreach (string vardas in names)
        //{
        //    Console.WriteLine(vardas);
        //}

        //for (int i = 1; i < 11; i++)
        //{
        //    for (int v = 1; v < 11; v++)
        //    {
        //        Console.WriteLine("i = " + i + " v = " + v);
        //    }
        //}


        //for (int i = 1; i < 11; i++)
        //{
        //    for (int v = 1; v < 11; v++)
        //    {
        //        Console.Write(i * v + " ");
        //    }
        //    Console.WriteLine();
        //}

        //int[][] arr2d =
        //    [
        //        [3, 5, 14],
        //        [7, 8, 3],
        //        [20, 14, 20]
        //    ];
        //Console.WriteLine("---------------");

        //for (int i = 0; i < arr2d.Length; i++)
        //{
        //    for (int b = 0; b < arr2d[i].Length; b++)
        //    {
        //        Console.Write(arr2d[i][b] + " ");
        //    }
        //}

        //string[] ss = ["a", "a"];


        int[] numbers = { 5, 65, 6485, 6561, 1, 384, 5615, 05, 135, 615, 651, 51, 135 };

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < numbers.Length; i++)// 0;       0   0   0   0   0
        {
            for (int a = i; a < numbers.Length; a++) //0;   1   2   3   4   5
            {
                if (numbers[i] > numbers[a])
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[a];
                    numbers[a] = temp;
                }
                for (int c = 0; c < numbers.Length; c++)
                {
                    Console.Write(numbers[c] + " ");
                }
                Console.WriteLine();

            }
        }
        Console.WriteLine("----------------");


        int[] fileredArray = new int[numbers.Length];
        int len = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < 70)
            {
                fileredArray[len++] = numbers[i];
            }
        }

        int[] filteredArrayPolished = new int[len];
        for (int i = 0; i < len; i++)
        {
            filteredArrayPolished[i] = fileredArray[i];
        }

        for (int c = 0; c < filteredArrayPolished.Length; c++)
        {
            Console.Write(filteredArrayPolished[c] + " ");
        }
        Console.WriteLine();
    }
}

