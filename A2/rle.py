# def encode(text):
#     code = [0]*(len(text)*2)
#     j = 0
#     i = 0
#     while text[i] != 0:
#         code[j] = text[i]
#         while code[j+1] != 0:
#             code[j+1] += 1
#             text[i] -= code[j]
#         #if i != len(text)-1 and code[j] != text[i+1]:
#             j += 2
#         i+=1
#     return (code, text, i, j)

def encode(text):
    code = [0]*(len(text)*2)
    j = 0
    i = 0
    while text[i] != 0:
        code[j] = text[i]
        code[j+1] += 1
        if i != len(text)-1 and code[j] != text[i+1]:
            j += 2
        i+=1
    return (code, text, i, j)


def decode(code):
    text = []
    i = 0
    while code[i] != 0:
        text += ([code[i]]*(code[i+1]))
        i += 2
    rem = (int(len(code)/2))-len(text)
    text = text + [0]*rem
    return text

text = [3, 3, 7, 7, 7, 5, 5, 5, 5, 0]
code = encode(text)
newText = decode(code[0])
print(text)
print(code)
print(newText)
