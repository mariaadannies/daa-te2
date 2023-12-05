# Dynamic Programming based python
# program to partition problem
 
# Returns true if arr[] can be
# partitioned in two subsets of
# equal sum, otherwise false
 
 
def find_partition(arr, n):
    total = 0
    i, j = 0, 0
 
    # calculate sum of all elements
    for i in range(n):
        total += arr[i]
 
    if total % 2 != 0:
        return False
 
    part = [[True for i in range(n + 1)]
            for j in range(total // 2 + 1)]
 
    # initialize top row as true
    for i in range(0, n + 1):
        part[0][i] = True
 
    # initialize leftmost column,
    # except part[0][0], as 0
    for i in range(1, total // 2 + 1):
        part[i][0] = False
 
    # fill the partition table in
    # bottom up manner
    for i in range(1, total // 2 + 1):
 
        for j in range(1, n + 1):
            part[i][j] = part[i][j - 1]
 
            if i >= arr[j - 1]:
                part[i][j] = (part[i][j] or
                              part[i - arr[j - 1]][j - 1])
 
    return part[total // 2][n]
 
 
# Driver Code
arr = [7, 4, 3, 7, 2, 1, 0, 6, 10, 4]

def set_partition_dp(arr):
    n = len(arr)
    # Function call
    if find_partition(arr, n) == True:
        return "Ada partisi yang memenuhi syarat."
    else:
       return "Tidak ada partisi yang memenuhi syarat."
    
# print(set_partition_dp(arr))
 
# This code is contributed
# by mohit kumar 29