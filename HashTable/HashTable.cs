using System;
using System.Collections;

namespace Implementations
{
    public class HashTableNumbers
    {
        private Hashtable numbers;
        public HashTableNumbers()
        {
            numbers = new Hashtable();
        }

        /*  Inserts values into hash table
         *  INPUT: takes a string for both the key and value         
         */
        public void Insert(string Key, string Val)
        {
            numbers.Add(Key, Val);
        }

        /* Checks if key is in hash table and removes it
         * INPUT: a string for the key in the hash table
         * OUTPUT: returns true if key found and removed
         *         false if key not found
         */
        public Boolean Remove(string Key)
        {
            if (numbers.Contains(Key))
            {
                numbers.Remove(Key);
                return true;
            }
            return false;
        }

        /* Checks if key in hash table, then returns corresponding value
         * INPUT: a string for the key
         * OUTPUT: the value corresponding to the input string or a generic
         *      message if key not found
         */
        public string GetVal(string Key)
        {
            if(numbers.Contains(Key))
            {
                return (string)numbers[Key];
            }
            return "No value with that key";
        }
    }
}
