//try
//{
//    int x = 5;
//    int y = x / 0;
//    Console.WriteLine($"Результат: {y}");
//}
//catch
//{
//    Console.WriteLine("Возникло исключение!");
//}
//finally
//{
//    Console.WriteLine("Блок Finally");
//}
//Console.WriteLine("Конец программы");

//Square("12");
//Square("ab");

//void Square(string data)
//{
//    // TryParse возвращает true, если конвертация успешна, 
//    // и записывает результат в переменную x
//    if (int.TryParse(data, out int x))
//    {
//        Console.WriteLine($"Квадрат числа {x}: {x * x}");
//    }
//    else
//    {
//        Console.WriteLine($"Ошибка: строка '{data}' не является числом.");
//    }
//}