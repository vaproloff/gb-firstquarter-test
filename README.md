![Geekbrains](https://frontend-scripts.hb.bizmrg.com/unique-hf/svg/logo_gb_dark_mobile.svg)
# Итоговая проверочная работа

* Студент: [**Константин Пивнов**](https://gb.ru/users/1215073).

---

## Задача:
> Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

---

## Решение:
Нам понадобятся следующие методы:
* запрашивания длины массива от пользователя
* запрашивания массива от пользователя
* вывода массива строк в консоль
* фильтрации элементов массива по максимальному количеству символов

Разберём каждый метод:
1. Запрашиваем строку у пользователя методом `Console.ReadLine()`, пробуем распарсить её в число. Если успешно - сохраняем в переменную количества элементов будущего массива.

2. Метод ввода массива основан на цикле, в котором будет вызываться метод `Console.ReadLine()`, а результаты - записываться в массив заданной длины, полученной от пользователя.

3. Метод вывода также основан на цикле `for`, в котором формируется строка для вывода, разделяя элементы запятой и оформляя в кавычки (как в примере задания). Обрамляем в квадратные скобки, выводим строку в консоль.

4. В методе фильтрации создаём новый массив такого же размера, что и старый, заводим счётчик подходящих элементов. В цикле `for` проходим по изначальному массиву, сравнивая каждый элемент с заданным максимальным количеством символов. Если элемент подходит нам - сохраняем в новый массив и увеличиваем счётчик. В новом массиве отрезаем пустые элементы и возвращем его в консоль.

В программе будет задана константа - максимальное количество символов (3 - согласно задаче).
Получаем от пользователя длину массива, затем сам массив. Предусматриваем ввод неверного значения длины массива, выводим ошибку в этом случае.
Выводим в консоль *изначальный* массив и затем *отфильтрованный*. 