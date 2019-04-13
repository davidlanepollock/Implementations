using System;

namespace Implementations
{
    class MainClass
    {
        static HashTableNumbers table;
        public static void Main(string[] args)
        {
            table = new HashTableNumbers();
            table.insert("1", "First Value");
            table.insert("2nd", "Number Two");
            table.insert("Third", "Third Value");
            
            Console.WriteLine(table.getVal("Third"));
            table.remove("2nd");
            Console.WriteLine(table.getVal("2nd"));
            Console.ReadKey();
        }
    }
}
