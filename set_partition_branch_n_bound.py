nodes_visited = 0

def partition_values(values):
    # Sort the values in descending order
    values.sort(reverse=True)
    
    # Rest of the code remains the same
    best_assignment = [False] * len(values)
    test_assignment = [False] * len(values)
    total_value = sum(values)
    best_err = [total_value]

    partition_values_from_index(values, 0, total_value, total_value,
                                test_assignment, 0, best_assignment, best_err)
    
    if min(best_err) != 0:
        return "Tidak ada partisi yang memenuhi syarat."
    
    return "Ada partisi yang memenuhi syarat."

def partition_values_from_index(values, start_index, total_value,
                                unassigned_value, test_assignment, test_value,
                                best_assignment, best_err):
    global nodes_visited
    if start_index >= len(values):
        test_err = abs(2 * test_value - total_value)
        if test_err < best_err[0]:
            best_err[0] = test_err
            best_assignment[:] = test_assignment[:]
    else:
        test_err = abs(2 * test_value - total_value)
        if test_err - unassigned_value < best_err[0]:
            unassigned_value -= values[start_index]
            test_assignment[start_index] = True
            nodes_visited += 1
            partition_values_from_index(values, start_index + 1, total_value, unassigned_value,
                                        test_assignment, test_value + values[start_index],
                                        best_assignment, best_err)

            test_assignment[start_index] = False
            nodes_visited += 1
            partition_values_from_index(values, start_index + 1, total_value, unassigned_value,
                                        test_assignment, test_value,
                                        best_assignment, best_err)

# print(partition_values([7, 4, 3, 7, 2, 1, 0, 6, 10, 4]))
