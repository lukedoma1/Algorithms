#Sorts in O(nlog(n)) time
def MergeSort(arr):
    width = 1
    n = len(arr)

    # Work on subarrays of increasing size
    while width < n:
        for i in range(0, n, 2 * width):
            left = arr[i : i + width]
            right = arr[i + width : i + 2 * width]
            arr[i : i + 2 * width] = merge(left, right)
        width *= 2
    
    return arr

def merge(left, right):
    result = []
    i = j = 0

    while i < len(left) and j < len(right):
        if left[i] <= right[j]:
            result.append(left[i])
            i += 1
        else:
            result.append(right[j])
            j += 1
    result.extend(left[i:])
    result.extend(right[j:])
    return result
        

def PrintArray(array):
    print()
    for item in array:
        print(item, end=" ")
    print()


array = [1, 9, 10, 8, 5, 8, 3, 5, 4, 2]


PrintArray(array)
MergeSort(array)
PrintArray(array)
