def compute():
    pentagonal_numbers = set()
    for i in range(1, 5000):
        for j in range(i + 1, 5000):
            first_number = make_pentagonal_number(j)
            second_number = make_pentagonal_number(i)
            numbers_sub = first_number - second_number
            numbers_sum = first_number + second_number
            if first_number not in pentagonal_numbers:
                pentagonal_numbers.add(first_number)
            if numbers_sum in pentagonal_numbers and numbers_sub in pentagonal_numbers:
                return numbers_sub
    return -1


def make_pentagonal_number(number):
    return number * (3 * number - 1) // 2


if __name__ == "__main__":
    print(compute())
