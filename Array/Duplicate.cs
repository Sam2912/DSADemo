using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSADemo.Array
{
    public class Duplicate
    {
        private bool MDuplicate()
        {
            int[] array = [1, 2, 3, 5];

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool MDuplicateHashSet()
        {
            int[] array = [1, 2, 3, 5,2];
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < array.Length ; i++)
            {
                if (set.Contains(array[i]))
                {
                    return true;
                }
                else
                {
                    set.Add(array[i]);
                }
            }
            return false;
        }
        public void Test()
        {
            System.Console.WriteLine(MDuplicateHashSet());
        }


    }
}