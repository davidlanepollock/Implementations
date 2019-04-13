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
        public void insert(string numKey, string Val)
        {
            numbers.Add(numKey, Val);
        }
        public Boolean remove(string numKey)
        {
            if (numbers.Contains(numKey))
            {
                numbers.Remove(numKey);
                return true;
            }
            return false;
        }
        public string getVal(string numKey)
        {
            if(numbers.Contains(numKey))
            {
                return (string)numbers[numKey];
            }
            return "No value with that key";
        }
    }
}
