#Sorts in O(nlog(n)) time
def MergeSort(arr):
    if len(arr) <= 1:
        return arr
    
    mid = len(arr) // 2 

    leftHalf = MergeSort(arr[:mid])
    rightHalf = MergeSort(arr[mid:])

    return Merge(leftHalf, rightHalf)

        
#MergeSort helper function
def Merge(left, right):
    merged = []
    i = j = 0

    while i < len(left) and j < len(right):
        if left[i] < right[j]:
            merged.append(left[i])
            i += 1
        else:
            merged.append(right[j])
            j += 1
    
    #make sure all left over elements are added
    merged.extend(left[i:])
    merged.extend(right[j:])

    return merged
        

def PrintArray(array):
    print()
    for item in array:
        print(item, end=" ")
    print()


array = [1, 9, 10, 8, 5, 8, 23, 20, 
         19, 15, 14, 19, 16, 15, 14, 
         2, 14, 2, 142, 14, 5, 4, 2]


PrintArray(array)
array = MergeSort(array)
PrintArray(array)
