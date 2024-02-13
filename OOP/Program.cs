namespace OOP;

internal class Program
{
    static void Main(string[] args)
    {
        Person p = new Person();
        // p.firstName = "Naglis";
        p.id = 1;

        p.setFirstName("Naglis");
        p.lastName = "Mockevičius";
        p.birthYear = 1990;
        p.gender = true;
        Console.WriteLine(p.id);

        Person p2 = new Person();
        //  p2.firstName = "Jurga";
        p2.setFirstName("Jurga");
        p2.lastName = "Povilionytė";
        p2.birthYear = 1992;
        p2.gender = false;
        Random r = new Random();
        r.Next();
        r.Next(10);
        r.Next(5, 10);
        Person p3 = new Person("Rokas", "Žilinskas", 1974, true);
        Console.WriteLine(p3);
        Console.WriteLine(p3.getFirstName());

        Person p4 = new Person();
        p4.FirstName = "          jOKUBAS      ";
        p4.lastName = "Vaisgantas";
        Console.WriteLine(p4);
        //Console.WriteLine(
        //    $"Sveiki, aš esu {p.firstName} {p.lastName}." +
        //    " Aš esu " + ((p.gender) ? "vyras" : "moteris") +
        //    $". gimiau {p.birthYear} metais.");
        //   Console.WriteLine(p);
        //    Console.WriteLine(p2);


        //Console.WriteLine(p);
        //Console.WriteLine(p.ToString());
        Console.WriteLine(p.info());
        Console.WriteLine(p2.info());
        Person.classIntro();

        Console.WriteLine(p.getAge());
        Console.WriteLine(p2.getAge());
        //        (bool) ? true : false
        //if (p.gender)
        //{
        //    Console.WriteLine("vyras");
        //}
        //else
        //{
        //    Console.WriteLine("moteris");
        //}
        //Console.WriteLine((p.gender) ? "vyras" : "moteris");
        int[] nums = { 4, 5, 8 };
        string[] names = { "Jonas", "Petras", "Vilius" };
        char[] letters = { 'A', 'B', 'C' };
        bool[] maybies = { true, true, false };
        Helper.printArr(nums);
        Helper.printArr(names);
        Helper.printArr(letters);
        Helper.printArr(maybies);

        Citizen c = new Citizen();
        Citizen c2 = new Citizen(1, "Jonas", "Jonavicius", 1994, true, "39405471658", "Lietuvis", "Kaunas");

        Console.WriteLine(c2);
        c2.whoAmI();

        Employee e = new Employee(1, "Petras", "Petrauskas", 1994, true, "39405471658",
            "Lietuvis", "Kaunas", "Kitronas", "suvirintojas");


        Console.WriteLine(Item.idCount);

        Item i = new Item("siurblys", "siurbia, akumuliatorinis");

        Console.WriteLine(i);
        Item i2 = new Item();
        i2.title = "title";
        i2.description = "description";
        Console.WriteLine(i2);
        Console.WriteLine(Item.idCount);


        int[] numsOld = new int[5];
        numsOld[0] = 5;
        Console.WriteLine(numsOld[0]);
        Console.WriteLine(numsOld.Length);

        List<int> numsNew = new List<int>();
        numsNew.Add(5);
        Console.WriteLine(numsNew[0]);
        Console.WriteLine(numsNew.Count);
        Console.WriteLine(numsNew);
        Console.WriteLine("---------------");
        List<string> namesL = new List<string>();

        namesL.Add("jurgis");
        namesL.Add("Petras");
        namesL.Add("antanas");
        Console.WriteLine(namesL.Count);

        namesL.Add("jurgis");
        namesL.Add("igoris");
        namesL.Add("jurgis");
        namesL.Add("jonas");
        Console.WriteLine(string.Join(',', namesL.Distinct()));
        Console.WriteLine(namesL.Count);
        namesL.Remove("jurgis");
        Console.WriteLine(namesL.Count);
        namesL.RemoveAt(1);


        Console.WriteLine("---------------");
        int[] numsGrow = new int[0];
        numsGrow = add(numsGrow, 4);
        numsGrow = add(numsGrow, 5);
        numsGrow = add(numsGrow, 7);
        numsGrow = add(numsGrow, 10);
        Console.WriteLine(numsGrow.Length);

        string[] strGrow = new string[0];
        strGrow = add(strGrow, "labas");
        strGrow = add(strGrow, "labas");
        strGrow = add(strGrow, "labas");
        strGrow = add(strGrow, "labas");
        strGrow = add(strGrow, "labas");

        List<int> newList = new List<int>();
        var newList2 = new List<int>();
        List<int> newList3 = new();
    }

    public static string[] add(string[] arr, string str)
    {
        string[] newArr = new string[arr.Length + 1];
        for (int i = 0; i < arr.Length; i++)
        {
            newArr[i] = arr[i];
        }
        newArr[arr.Length] = str;
        return newArr;
    }
    public static int[] add(int[] arr, int num)
    {
        int[] newArr = new int[arr.Length + 1];
        for (int i = 0; i < arr.Length; i++)
        {
            newArr[i] = arr[i];
        }
        newArr[arr.Length] = num;
        return newArr;
    }

}

