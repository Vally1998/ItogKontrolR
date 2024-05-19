Задача: 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []

Решение

1. Сначала создадим массив из 4-х элементов
2. Теперь нужно описать код с помощью цикла for для перебора каждого элемента массива и сравнения его величины с 3 c помощью создания 
функции myArray, которая будет перебирать каждый элемент массива, сравнивать его величину с 3мя знаками, перемещаясь по всему массива до его конца
3. Теперь напишем функцию вывода на консоль нового сформированного массива с помощью функции PrinArray также через перебор элементов 
с помощью цикла for

[Решение в коде](ItogKontrolR\Program.cs)

[Решение в в иде блок-схемы](ItogKontrolR\Диаграмма.drawio.png)


