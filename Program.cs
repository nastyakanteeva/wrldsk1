// Считывание значения n с консоли и преобразование его в тип double
double n = Convert.ToDouble(Console.ReadLine());

// Считывание значения x с консоли и преобразование его в тип double
double x = Convert.ToDouble(Console.ReadLine());

// Проверка условия: если абсолютное значение x больше или равно -1 и меньше 1
if (x >= -1 && x < 1)
{
    // Инициализация переменной result как 0
    double result = 0;

    // тело цикла  с учетом введенного n
    for (double i = 0; i <= n; i++)
    {
        // тело цикла
        result += Math.Pow(x, n) / (n);
    }

    // Результат ряда умножается на -1
    result *= -1;

    // Вывод результата на консоль
    Console.WriteLine(result);
}
else
{
    // В случае если условие не выполнено, выводится сообщение об ошибке
    Console.WriteLine("Error:|х| < 1");
}