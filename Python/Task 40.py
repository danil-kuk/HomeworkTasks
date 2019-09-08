def compute(numbers_string):
    result = int(numbers_string[1])
    for i in range(1, 7):
        result *= int(numbers_string[pow(10, i)])
    return result


def make_numbers_string():
    numbers = ""
    current = 0
    while len(numbers) < 1000001:
        numbers += str(current)
        current += 1
    return numbers


if __name__ == "__main__":
    print(compute(make_numbers_string()))