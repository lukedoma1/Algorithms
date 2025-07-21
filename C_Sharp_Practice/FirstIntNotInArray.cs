using System;
using System.Collections.Generic;

class Program
{
    //Solution accepts an array of Integers
    //Returns smallest Integer not in array from 1 to 100,000
    static int Solution(int[] array)
    {
        HashSet<int> set = new HashSet<int>();

        //Add all values in array to the HashSet.
        foreach( int n in array )
        {
            set.add(n);
        }

        int missingNum;

        //Find the first integer not in array, 
        //if all the integers are there, then the next integer
        //will be returned. 
        for( int i = 1; i < array.Length + 1; i++ )
        {
            //if set doesn't contain i, break the for loop,
            //the number is found!
            if(!set.Contains(i))
            {
                missingNum = i;
                break;
            }
        }

        if(missingNum > 100000)
        {
            missingNum = -1;    //if there were all numbers to 100,000
                                //then return error (-1);
        }
        
        return missingNum;
    }
}