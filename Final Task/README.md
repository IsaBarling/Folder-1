Формулировка задачи

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна трём символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Алгоритм программы

**Этап 1** *Создание первичного массива для выборки*

Пользователь вводит данные массива через запятую и завершает ввод нажатием клавиши Enter

**Этап 2** *Выборка тех строк, где меньше четырех символов*.

Задаем цикл, на каждой итерации цикла проверяем длину текушей строки
Если текущий элемент удовлетворяет условиям, добавляем его во второй массив

**Этап 3** *Вывод результатов*.

Выводим все элементы второго массива, либо выводим сообщение, что элементов не найдено.
