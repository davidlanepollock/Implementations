using System;

namespace Implementations
{
    class MainClass
    {
        static HashTableNumbers table;
        public static void Main(string[] args)
        {
            table = new HashTableNumbers();
            InsertVals();
            
            Console.WriteLine(table.GetVal("Third"));
            table.Remove("2nd");
            Console.WriteLine(table.GetVal("2nd"));
            Console.ReadKey();
        }

        /*  Inserts pre-set values into the HashTableNumbers class
         *  
         */
        public static void InsertVals()
        {
            table.Insert("1", "First Value");
            table.Insert("2nd", "Number Two");
            table.Insert("Third", "Third Value");
        }
    }

}
