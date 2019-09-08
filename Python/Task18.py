import re


def compute(triangle):
    for i in reversed(range(len(triangle) - 1)):
        for j in range(len(triangle[i])):
            triangle[i][j] += max(triangle[i + 1][j], triangle[i + 1][j + 1])
    return str(triangle[0][0])


def get_triangle():
    file = open(r"../Task18/Triangle.txt", "r")
    lines = file.readlines()
    triangle = [[]]
    for line in lines:
        temp = re.findall(r'\d+', line)
        res = list(map(int, temp))
        triangle.append(res)
    return list(filter(None, triangle))


if __name__ == "__main__":
    print(compute(get_triangle()))
