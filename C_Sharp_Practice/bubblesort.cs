using system;
using system.collection.generic;

class Program
{

    //BubbleSort accepts a list of numbers
    //Returns nothing
    //static, since it doesn't need any instance fields
    static void BubbleSort(int[] array)
    {
        bool sorted = false;

        while (!sorted)
        {
            sorted = true;

            for (int i = 0; i < array.length-1; i++)
            {

                //if the next number in the array is larger than the current
                //number, then switch them, and make sure to repeat the while
                //loop again to make sure it is in the correct order now.
                if (array[i] > array[i+1])
                {
                    int placeHolder = array[i];
                    array[i] = array[i+1];
                    array[i+1] = array[i];
                    sorted = false;
                }
            }
        }
    }

    static void PrintArray(int[] array)
    {
        Console.Write("\n{ ");
        foreach( int n in array)
        {
            Console.Write(n + " ")
        }
        Console.Write("}\n");
    }

    static void main(string[] args)
    {
        int[] numbers = {5, 1, 9, 2, 6, 3, 8, 5, 3, 8, 7, 9};

        PrintArray(numbers);
        BubbleSort(numbers);
        PrintArray(numbers);
    }
}