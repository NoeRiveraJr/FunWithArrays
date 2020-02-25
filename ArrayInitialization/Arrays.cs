using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulatingArrays
{
    class Arrays
    {
        static void Main()
        {
            int[] a = { 0, 2, 4, 6, 8, 10 }; //initializes 3 different arrays with different values and lengths
            int[] b = { 1, 3, 5, 7, 9 };
            int[] c = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            ArrayFunctions arr = new ArrayFunctions(); //instantiuated an object from the ArrayFunctions class
            Console.Write("Array A is (");
            arr.printArray(a);
            Console.Write(")\n");
            Console.Write("Array B is (");
            arr.printArray(b);
            Console.Write(")\n");
            Console.Write("Array C is (");
            arr.printArray(c);
            Console.WriteLine(")\n");

            Console.WriteLine($"The average of the array A is: {arr.arrayAverage(a)}");
            Console.WriteLine($"The average of the array B is: {arr.arrayAverage(b)}");
            Console.WriteLine($"The average of the array C is: {arr.arrayAverage(c)}\n");

            Console.Write("Array A backwards is(");
            foreach(int x in arr.arrayBackwards(a))
            {
                Console.Write(x + " ");
            }
            Console.Write(")\n");
            Console.Write("Array B backwards is(");
            foreach (int x in arr.arrayBackwards(b))
            {
                Console.Write(x + " ");
            }
            Console.Write(")\n");
            Console.Write("Array C backwards is(");
            foreach (int x in arr.arrayBackwards(c))
            {
                Console.Write(x + " ");
            }
            Console.Write(")\n");


            Console.Write("\nArray A rotated to the left 2 places is(");
            foreach (int x in arr.rotateArray("left", 2, a)) //will move the values in array A 2 spaces to the left
            {
                Console.Write(x + " ");
            }
            Console.Write(")\n");
            Console.Write("Array B rotated to the right 2 places is(");
            foreach (int x in arr.rotateArray("right", 2, b)) //will move the values in array B 2 spaces to the right
            {
                Console.Write(x + " ");
            }
            Console.Write(")\n");
            Console.Write("Array C rotated to the left 4 places is(");
            foreach (int x in arr.rotateArray("left", 4, c)) //will move the values in array C 4 spaces to the left
            {
                Console.Write(x + " ");
            }
            Console.Write(")\n\n");


            Console.Write("Array A sorted from least to greatest is (");
            foreach (int x in arr.sortArray(a))
            {
                Console.Write(x + " ");
            }
            Console.Write(")\n");
            Console.Write("Array B sorted from least to greatest is (");
            foreach (int x in arr.sortArray(b))
            {
                Console.Write(x + " ");
            }
            Console.Write(")\n");
            Console.Write("Array C sorted from least to greatest is (");
            foreach(int x in arr.sortArray(c))
            {
                Console.Write(x + " ");
            }
            Console.Write(")\n");
        }
      
    }
}
