def compute():
    prev = 0
    current = 1
    index = 1
    while len(str(current)) < 1000:
        prev, current = current, prev + current
        index += 1
    return index


if __name__ == "__main__":
    print(compute())
