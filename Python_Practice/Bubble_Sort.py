def BubbleSort(array):
    sorted = False
    n = len(array)
    while(sorted == False):
        sorted = True
        for i in range(n-2):
            if(array[i] > array[i+1]):
                temp = array[i+1]
                array[i+1] = array[i]
                array[i] = temp
                sorted = False

def PrintArray(array):
    print()
    for element in array:
        print(element, end=' ')

myArray = [1, 9, 10, 4, 2, 9, 8]

PrintArray(myArray)
BubbleSort(myArray)
PrintArray(myArray)