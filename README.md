## Задача ##
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры: ["hello", "2", "world", ":-)"] -> ["2", ":-)"] ["1234", "1567", "-2", "computer science"] -> ["-2"] ["Russia", "Denmark", "Kazan"] -> []


## Алгоритм решения задачи ##

1. Создаем блок ввода данных и вывода массива в консоль. В данном решении пользователь сам задает длину массива и вводит элементы. 
2. Далее заводим функцию CheckArr, которая определяет количество элементов, содержащих не более ilength символов. Для этого используем цикл for и цикл if со счетчиками i и result соответственно.
3. В новую переменную elements записываем элементы массива, имеющие ilength символов или меньше.
4. Запускаем метод NewArray, с помощью которого перебором элементов старого массива мы получим новый массив из тех элементов, которые удовлетворяют условию задачи.
5. С помощью метода PrintArray выводим новый массив в консоль.