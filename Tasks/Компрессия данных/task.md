Условие задачи
Компрессия данных (англ. data compression) — алгоритмическое (обычно обратимое) преобразование данных, производимое с целью уменьшения занимаемого ими объёма.
Вам предстоит реализовать простейший алгоритм компрессии последовательности чисел, который предполагает, что последовательность состоит из подряд идущих возрастающих или убывающих отрезков чисел.
Формально, будем представлять результат компрессии как новую последовательность чётной длины вида 
, где пара идущих подряд членов означает, что: если 
, что в искомой последовательности был возрастающий отрезок вида 
 если, что в искомой последовательности был убывающий отрезок вида 
Например, если искомая последовательность имела вид 
a=[3,2,1,0,−1,0,6,6,7]
, то результат сжатия может иметь вид [3,−3,−1,1,6,0,6,1]
. Другой возможный результат сжатия: 
[3,−4,0,0,6,0,6,1]
По заданной последовательности 
a выведите такой результат сжатия, который имеет наименьшую длину (последовательность-результат содержит минимальное количество элементов). Если такое сжатие неоднозначно, то выведите любое из них.
Входные данные
В первой строке входных данных записано целое число 
1≤t≤100 — количество наборов входных данных.
Наборы входных данных в тесте независимы. Друг на друга они никак не влияют.
Каждый набор входных данных состоит из двух строк.
В первой из них записано целое число 
1≤n≤50 — длина заданной последовательности a. 
Во второй содержится последовательность целых чисел 
−1000≤ai≤1000 — элементы последовательности a.
Выходные данные
Для каждого набора входных данных выведите ответ в виде пары строк. Первая строка должна содержать длину результата (чётное положительно число), вторая должна содержать результат оптимального сжатия — последовательность целых чисел.
Учтите, что в процессе компрессии длина последовательности может увеличиться.
Если существует несколько способов сжать заданную последовательность так, чтобы количество элементов в результате было наименьшим, выберите любой из них.
Пример теста 1
Входные данные
5
9
3 2 1 0 -1 0 6 6 7
1
1000
7
1 2 3 4 5 6 7
7
1 3 5 7 9 11 13
11
100 101 102 103 19 20 21 22 42 41 40
Выходные данные
8
3 -4 0 0 6 0 6 1
2
1000 0
2
1 6
14
1 0 3 0 5 0 7 0 9 0 11 0 13 0
6
100 3 19 3 42 -2
