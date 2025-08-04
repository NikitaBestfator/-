from itertools import groupby

#
# Подсчитывает слова в тексте.
#
path = "D:\\_Programming\\LearnData\\CalcWords\\Words1.txt"
#print(path)

with open(path, "r", encoding="utf-8") as file:
    content =  file.read() #Весь текст в одной строке
#print(content)
words = content.split()
print(words)

words_counts = {}

for w in words:
    if words_counts.get(w) :
        words_counts[w] = words_counts[w] + 1 
    else:
        words_counts[w] = 1
        

sorted_words = dict(sorted(words_counts.items(), key=lambda item:item[1]))
print(sorted_words)
reverse_words = list(reversed(sorted_words))
print(reverse_words)
for x in reverse_words:
    print(x, " - ", words_counts.get(x))
    