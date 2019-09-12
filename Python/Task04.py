def compute():
    max_palindrome = 0
    for i in range(999, 100, -1):
        for j in range(999, 100, -1):
            number = i * j
            if is_palindrome(number) and number > max_palindrome:
                max_palindrome = number
    return max_palindrome


def is_palindrome(number):
    number = str(number)
    return number[:3] == number[:-4:-1]


if __name__ == "__main__":
    print(compute())