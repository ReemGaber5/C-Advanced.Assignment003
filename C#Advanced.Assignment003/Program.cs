using System.Collections;

namespace C_Advanced.Assignment003
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question1
            //int[] arr = { 1, 1, 1, 2, 2, 3, 4, 5, 5, 5, 5 };

            //Hashtable hashtable = new Hashtable();

            //foreach (int i in arr)
            //{
            //    if(hashtable.ContainsKey(i))
            //    {
            //        hashtable[i] =(int)hashtable[i] + 1;
            //    }
            //    else
            //        hashtable[i] = 1;
            //}

            //foreach (DictionaryEntry entry in hashtable)
            //{
            //    Console.WriteLine($"{entry.Key}: {entry.Value}");
            //}

            #endregion

            #region Question2

            //Hashtable table = new Hashtable
            //{
            //    { "A", 10 },
            //    { "B", 25 },
            //    { "C", 18 }
            //};

            //string highestkey=FindKeyWithHighestValue(table);
            //Console.WriteLine(highestkey);
            #endregion

            #region Question3
            //Hashtable Table = new Hashtable
            //{
            //    { "key1", "apple" },
            //    { "key2", "banana" },
            //    { "key3", "apple" }
            //};
            //FindKeysWithTargetValue(Table, "apple");

            #endregion

            #region Question4

            #endregion

            #region Question5
            //int[] arr = { 1, 2, 3, 4, 5,5};
            //HashSet<int> set = new HashSet<int>();

            //bool hasduplicate = false;
            //foreach (int i in arr)
            //{
            //    if (set.Contains(i)) 
            //     hasduplicate = true;
            //    set.Add(i);

            //}

            //Console.WriteLine(hasduplicate ? "Contains duplicates" : "No duplicates");


            #endregion

            #region Question6
            //SortedDictionary<int,string> sd = new SortedDictionary<int,string>();
            //sd.Add(1, "Reem");
            //sd.Add(2, "Ali");
            //sd.Add(3, "Ahmed");
            //sd.Add(4, "Mohammed");


            //foreach(KeyValuePair<int,string> kvp in sd)
            //{
            //    Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            //}

            //Console.WriteLine("=================================== Afer implement remove =========================================");
            //sd.Remove(1);

            //foreach (KeyValuePair<int, string> kvp in sd)
            //{
            //    Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            //}
            #endregion

            #region Question 7
            //SortedList<int, string> sd = new SortedList<int, string>();
            //sd.Add(1, "Reem");
            //sd.Add(2, "Ali");
            //sd.Add(3, "Ahmed");
            //sd.Add(4, "Mohammed");


            //foreach (KeyValuePair<int, string> kvp in sd)
            //{
            //    Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            //}

            //Console.WriteLine("=================================== Afer implement remove =========================================");
            //sd.Remove(1);

            //foreach (KeyValuePair<int, string> kvp in sd)
            //{
            //    Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            //}
            #endregion

            #region Question8
            //int ArrayNumbers = 10;
            //int[] arr = { 1, 2, 4, 6, 7, 8, 10 };

            //Console.WriteLine("Missing numbers:");
            //HashSet<int> set = new HashSet<int>(arr);
            //for (int i = 1; i < ArrayNumbers; i++)
            //{
            //    if(!set.Contains(i))
            //        Console.WriteLine(i);
            //}
            #endregion

            #region Question9
            //int[] numbers = { 1, 2, 3, 4, 2, 3, 5, 6 };
            //HashSet<int> set = new HashSet<int>(numbers);
            //Console.WriteLine("Unique numbers: " + string.Join(", ", set));

            #endregion

            #region Question10

            #endregion

            #region Question11
            //HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4 };
            //HashSet<int> set2 = new HashSet<int> { 3, 4,5,6 };

            //set1.UnionWith(set2);
            //Console.WriteLine("Union of sets: " + string.Join(", ", set1));
            #endregion

            #region Question12
            //Dictionary<string,int> dic=new Dictionary<string,int>
            //{
            //    { "apple", 1 },
            //    { "animal", 2 },
            //    { "airport", 3 },
            //    { "banana", 4 }
            //};

            //Console.WriteLine("Enter target cahr:");
            //char targetchar=Console.ReadLine()[0];

            //int count = 0;
            //foreach (KeyValuePair<string, int> kvp in dic)
            //{
            //    if(kvp.Key.StartsWith(targetchar))
            //    {
            //        count++;
            //    }

            //}
            //Console.WriteLine($"Keys starting with '{targetchar}': {count}");



            #endregion

        }
        #region Question2
        //public static string FindKeyWithHighestValue(Hashtable table)
        //{
        //    return table.Keys.Cast<string>()
        //        .OrderByDescending(k => (int)table[k])
        //        .First();
        //}

        #endregion

        #region Question3
        //public static void FindKeysWithTargetValue(Hashtable table, string targetvalue)
        //{
        //    bool found = false;

        //    foreach (DictionaryEntry entry in table)
        //    {
        //        if (entry.Value.ToString() == targetvalue)
        //        {
        //            Console.WriteLine(entry.Key);
        //            found = true;
        //        }

        //    }
        //    if (!found)
        //    {
        //        Console.WriteLine("key not found");
        //    }

        //}

        #endregion

    }
}
