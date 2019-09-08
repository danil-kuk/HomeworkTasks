def compute():
    max_sequence_length = 0
    result = 0
    for a in range(-999, 1000):
        for b in range(-1000, 1001):
            prime_numbers_count = check_equation(a, b)
            if prime_numbers_count > max_sequence_length:
                max_sequence_length = prime_numbers_count
                result = a * b
    return result


def check_equation(a, b):
    n = 0
    while is_prime_number(n**2 + n*a + b):
        n += 1
    return n


def is_prime_number(number):
    if number <= 1:
        return False
    for i in range(2, number):
        if number % i == 0:
            return False
    return True


if __name__ == "__main__":
    print(compute())