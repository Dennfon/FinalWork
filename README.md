# Итоговая контрольная работа по основному блоку

**Задача:**<br> *Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

**Примеры:**<br>
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]<br>
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]<br>
[“Russia”, “Denmark”, “Kazan”] → []<br>

**Решение:**<br>

1. Создаем два массива, присваеваем второму массиву длинну первого;
2. Создаем метод, который принимает на вход два массива. Потом в цикле проверяем условие, что Если (Значение в массив1.длинна < 4), тогда мы заносим это значение в массив 2
3. Создаем метод для выведения значений массива в консоль