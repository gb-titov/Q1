# Контрольная работа по I четверти

## Описание
---
Программа генерирует одинарный строковый массив заданной длины, формирует новый массив с строками длиной не более 3 знаков.


## Функционал 
---
### Два метода расширения для массивов:
1. Генерация 

```
var array = new string[length];
array.GenerateRandomStrings(minStringSize, maxStringSize);
```
`length` - Длина массива<br />
`minStringSize` - Минимальная длина строки<br />
`maxStringSize` - Максимальная длина строки<br />

2. Печать в консоль
```
array.PrintArrayToConsole()
```
### Формирование нового массива с строками заданной длины
```
var srv = new ArrayService();
var newArray = srv.GetStrings(array, maxNewStringSize);
```
`array` - Массив для поиска строк заданной длины<br />
`maxNewStringSize` - Максимальная длина строки нового массива<br />

### Блок-схема алгоритма
---

[БлокСхема](Q1Task.png)
