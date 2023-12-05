import random

def generate_dataset(arr):
    sizes = arr
    dataset = []

    for size in sizes:
        arr = [random.randint(0, size) for _ in range(size)]
        print(f"Array with size {size} : {arr[:10]}... ({len(arr)} elements in total)")
        dataset.append([arr, size])
        # print(dataset)
        # create txt file for each dataset
        with open(f"dataset_random_{size}.txt", "w") as file:
            for element in arr:
                file.write(f"{element}\n")
        file.close()
    return dataset