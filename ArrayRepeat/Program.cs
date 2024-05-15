using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRepeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TripleRepeat());
            Console.WriteLine();
            Console.WriteLine(Arraycontain());
            Console.WriteLine();
            Console.WriteLine(difference());
            Console.WriteLine();
            Console.WriteLine(sumArray());
            Console.WriteLine();
            //Console.WriteLine(Arrange());
            Arrange();
            Console.WriteLine();
        }


        public static bool TripleRepeat()
        {
            int[] a = { 1, 1, 1, 2, 2, 2, 1 };

            Console.WriteLine("Array: [{0}]", string.Join(", ", a));

            Console.WriteLine("Find triple repeat");
            for (int i = 0; i < a.Length-1; i++)
            {
                if (a[i] == a[i+1] && a[i] == a[i+2])
                {
                    return true;
                }
            }

            return false;

        }


        public static bool Arraycontain()
        {
            int[] a = new int[] { 1, 10, 30, 27, 40, 37, 25 };

            Console.WriteLine("Array: [{0}]", string.Join(", ", a));
            int n = 27;

            Console.WriteLine("Array contain {0}", n);
            

            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == n)
                {
                    return true;
                }
            }

            return false;

        }


        public static int difference()
        {
            int[] a = { 1, 5, 7, 9, 10, 12 };

            Console.WriteLine("Array: [{0}]", string.Join(", " ,a));

            Console.WriteLine("Difference between min and max");
            int min = a[0];
            int max = a[0];

            //if(a.Length > 0)
            //{
            //    min = max = a[0];
            //}

            for(int i = 0; i < a.Length;i++)
            {
                min = Math.Min(min, a[i]);
                max = Math.Max(max, a[i]);
            }

            int diff = max - min;

            return diff;

        }


        public static int sumArray()
        {
            int[] a = new int[] { 1, 5, 7, 9, 10, 17 };

            Console.WriteLine("Array: [{0}]", string.Join(", ", a));
           
            int sum = 0;
            int n = 17;

            Console.WriteLine("sum of array except {0}", n);
       

            for(int i = 0;i < a.Length;i++)
            {
                if (a[i] != n)
                {
                    sum += a[i];
                }
            }

            return sum;
        }


        public static void Arrange()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9};

            Console.WriteLine("Array: [{0}]", string.Join(", ", a));
            int index = 0;

            Console.WriteLine("Arrange even and odd ");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    int temp = a[index];
                    a[index] = a[i];
                    a[i] = temp;

                    index++;
                }
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
