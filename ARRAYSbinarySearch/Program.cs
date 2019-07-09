using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAYSbinarySearch
{
    class Program
    {
        public static void FindObject(Array array, Object obj)
        {
            int index = Array.BinarySearch(array, 0, array.Length, obj);
            Console.WriteLine();

            if(index > 0)
            {
                Console.WriteLine($"Object: {obj} found at {index}");
            }
            else if(~index == array.Length)
            {
                Console.WriteLine($"Object: {obj} not found. No array object has a greater value.");
            }
            else
            {
                Console.WriteLine($"Object: {obj} not found. Next larger object found at [{~index}]");
            }
        }

        static void Main(string[] args)
        {
            int[] ints = { 0, 10, 100, 1000, 100000, 1000000 };
            Console.WriteLine("Array indices and elements: ");

            for(int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine($"[{i}]={ints[i]}");
            }
            Console.WriteLine();
            FindObject(ints, 25);
            FindObject(ints, 1000);
            FindObject(ints, 200000);

        }
    }
}
