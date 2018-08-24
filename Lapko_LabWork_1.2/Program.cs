using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lapko_LabWork_1._2
{
    class Program
    {
        //TASK: Write three methods that calculate the sum of numbers in a list, using a for loop, a while loop, and recursion.
        public static void Main(string[] args)
        {

            int[] array = new int[] { 1, 2, 3 };

            Console.WriteLine("Sum array: {0}", getSumFor(array));
            Console.WriteLine("Sum array: {0}", getSumWhile(array));
            Console.WriteLine("Sum array: {0}", getSumRecursion(array));

            List<int> list = new List<int>() { 1, 2, 3 };

            Console.WriteLine("Sum list: {0}", getSumFor(list));
            Console.WriteLine("Sum list: {0}", getSumWhile(list));
            Console.WriteLine("Sum list: {0}", getSumRecursion(list));

            Console.ReadKey();

        }

        public static int getSumFor(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        public static int getSumFor(List<int> list)
        {
            int sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            return sum;
        }

        public static int getSumWhile(int[] array)
        {
            int sum = 0;
            int i = 0;

            while (i < array.Length)
            {
                sum += array[i];
                i++;
            }

            return sum;
        }

        public static int getSumWhile(List<int> list)
        {
            int sum = 0;
            int i = 0;

            while (i < list.Count)
            {
                sum += list[i];
                i++;
            }

            return sum;
        }

        public static int getSumRecursion(int[] array, int index = 0)
        {
            if (index >= array.Length)
            {
                return 0;
            }

            return array[index] + getSumRecursion(array, ++index);
        }

        public static int getSumRecursion(List<int> list, int index = 0)
        {
            if (index >= list.Count)
            {
                return 0;
            }

            return list[index] + getSumRecursion(list, ++index);
        }

    }
}
