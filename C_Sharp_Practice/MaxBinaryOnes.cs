using System;
using System.Collections.Generic;

class Program{

    //accepts an int as an input
    //returns the longest train of 1's between 0's in the binary encoding
    static int Solution(int Num)
    {
        int longestTrain = 0;
        int currentTrain = -1; //-1 until we see a 0 to wrap the 1's

        while(Num > 0)
        {
            if(Num & 1) //the rightmost bit is a 1
            {
                if(currentTrain != -1)
                {
                    currentTrain++;
                }
            }
            else //rightmost bit is a 0
            {
                if( longestTrain < currentTrain )
                {
                    longestTrain = currentTrain;
                }
                currentTrain = 0;
            }

            Num >>= 1; //shift bits right by one
        }
    }

    static void Main(string[] args)
    {
        int num = 11;
        Console.Write(Solution(num) + "\n");
    }
}