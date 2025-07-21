using System;
using System.Collections.Generic;


class Program{

    static int Solution(int[] array)
    {
        
        bool foundMiddle = false;
        int sumLeft = 0;
        int sumRight = 0;
        int j = 0; //left side array index (goes from left to right)
        int k = array.Length -1; //right side array index (goes from right to left)

        //find where the middle point of sums is
        while( k >= j ) 
        {
            if (sumLeft < sumRight) //sum of left side of array is less
            {
                sumLeft += array[j];
                j++;
            }
            else //sum of right side of array is less/equal
            {
                sumRight += array[k]; 
                k--;
            }
        }

        //return difference of sections
        return Math.Abs(sumLeft - sumRight);
    }

    static void Main(string[] args)
    {
        int[] array = {10, 1, 1, 1, 1};
        Console.Write(Solution(array));
        Console.WriteLine();
    }
}