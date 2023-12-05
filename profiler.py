import time
import psutil
from prettytable import PrettyTable
from set_partition_branch_n_bound import partition_values
from set_partition_dp import set_partition_dp
from random_dataset import generate_dataset   

def profile_algorithm_dp(data):
    start_time = time.time()
    process = psutil.Process()

    result = set_partition_dp(data)

    end_time = time.time()
    memory_used = process.memory_info().rss / (1024 * 1024)

    execution_time = end_time - start_time

    return result, execution_time, memory_used

def profile_algorithm_bnb(data):
    start_time = time.time()
    process = psutil.Process()

    result = partition_values(data)

    end_time = time.time()
    memory_used = process.memory_info().rss / (1024 * 1024)

    execution_time = end_time - start_time

    return result, execution_time, memory_used

arr = [10, 40, 80]
# generate_dataset(arr)
sizes = [10, 40, 80]
table_time = PrettyTable()
table_memory = PrettyTable()
table_time.field_names = ["Size", "Time DP", "TIme BNB", "Result DP", "Result BNB"]
table_memory.field_names = ["Size", "Memory DP", "Memory BNB", "Result DP", "Result BNB"]

for size in sizes:
    # read dataset from file
    with open(f"dataset_random_{size}.txt", "r") as file:
        data = file.read().splitlines()
        data = [int(element) for element in data]
    
    print("Loading DP...")
    result_1, time_1, memory_1 = profile_algorithm_dp(data)
    table_time.add_row([size, time_1, '', result_1, ''])
    table_memory.add_row([size, memory_1, '', result_1, ''])

    with open("output_test.txt", "w") as file:
        file.write("Execution Time Comparison\n")
        file.write(str(table_time))
        file.write("\n\n\n")
        file.write("Memory Usage Comparison\n")
        file.write(str(table_memory))

    print("Loading BNB...")
    result_2, time_2, memory_2 = profile_algorithm_bnb(data)
    table_time.add_row([size, time_1, time_2, result_1, result_2])
    table_memory.add_row([size, memory_1, memory_2, result_1, result_2])

    print("DP: Execution time =", time_1, "size = ", size)
    print("BNB: Execution time =", time_2, "size = ", size)

    print(table_time)
    print(table_memory)

    with open("output_test.txt", "w") as file:
        file.write("Execution Time Comparison\n")
        file.write(str(table_time))
        file.write("\n\n\n")
        file.write("Memory Usage Comparison\n")
        file.write(str(table_memory))