using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulatingArrays
{
    class ArrayFunctions
    {
        //this project was an introduction into manipulating arrays, it challenged me but I was able to overcome this by applying fundamental critical thinking
        public void printArray(int[] x) //this method will print the array to the Console
        {
            foreach(int y in x) //utilizing a foreach loop, which does not deal with indices
            {
                Console.Write(y + " ");
            }
        }

        public double arrayAverage(int[] x) //uses a double that is incremented by the value at index i, then divides by the array length to get average
        {
            double sum = 0;
            double avg;
            for(int i = 0; i < x.Length; i++) //utilizing a for loop to iterate through an array via indices, this is more effective than a foreach loop
            {
                sum += x[i];
            }
            avg = sum / x.Length;
            return avg;
        }

        public Array arrayBackwards(int[] x) //this method will return the array that is passed as an argument backwards
        {
            int[] y = new int[x.Length]; //initializes a blank array with the length as the array that is passed as an argument
            for(int i = 1; i <= x.Length; i++)
            {
                y[i-1] = x[x.Length - i]; //will iterate through the array that is an arguement starting at the end, and assigning it to the beginning of the new array
            }
            return y;
        }

        public Array rotateArray(string a, int b, int[] c) //takes a string parameter that will equal left or right, an int to determine how many spaces
        {                                                  //and an array to perform the function on, will move all values in an array by the speciied arguments
            int[] y = new int[c.Length];
            if (a.ToLower() == "left")
            {
                for (int i = 0; i < c.Length; i++)
                {
                    if ((i-b)<0)
                    {
                        y[(i - b + c.Length)] = c[i]; //this ensures that you will never go out of bounds when iterating thorugh the array
                    }
                    else
                    {
                        y[i-b] = c[i];
                    }
                }
            }
            else
            {
                for (int i =0; i < c.Length; i++)
                {
                    if ((i+b)>=c.Length)
                    {
                        y[i + b - c.Length] = c[i]; //this ensures that you will never go out of bounds when iterating through the array
                    }
                    else
                    {
                        y[i + b] = c[i];
                    }
                }

            }
            return y;
        }
       
        public Array sortArray(int[] x) //this method will sort any array from least to greatest 
        {                               //I utilize a double for loop to iterate through the for loop until it is completely sorted
            for (int i = 0; i <x.Length; i++)
            {
                for (int j = i+1 ; j<x.Length;j++)
                {
                    if ((x[i] > x[j]))
                    {
                        int save = x[j];
                        x[j] = x[i];
                        x[i] = save;
                    }
                }
            }
            return x;
        }

    }
}
