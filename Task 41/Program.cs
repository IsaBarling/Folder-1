int[] newArray = new int[0];

SetArray(ref newArray);
Console.WriteLine($"[{String.Join(",", newArray)}] -> {CheckNumberMoreZero(newArray)}");


int CheckNumberMoreZero(int[] array)
{
    int count = 0;
    foreach (int i in array)
    {
        if (i > 0)
        {
            count++;
        }
    }
    return count;
}

string ReadFromConsole()
{
    string result = string.Empty;
    while (true)
    {
        var k = Console.ReadKey(true);
        switch (k.Key)
        {
            case ConsoleKey.Backspace:
                if (result.Length > 0)
                {
                    result = result.Remove(startIndex: result.Length - 1, count: 1);
                    Console.Write(value: $"{k.KeyChar} {k.KeyChar}");
                }
                break;
            case ConsoleKey.Enter:
                Console.WriteLine();
                return result;
            case ConsoleKey.Escape:
                result = "out";
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.WriteLine(value: "Нажали Esc, цикла ввода массива завершен ");
                return result;
            default:
                if (char.IsDigit(c: k.KeyChar) || (k.KeyChar == '-' && result.Length == 0))
                {
                    Console.Write(value: k.KeyChar);
                    result += k.KeyChar;
                }
                break;
        }
    }
}

void SetArray(ref int[] array)
{
    while (true)
    {
        Console.WriteLine($"Введите число №{array.Length + 1} (Для окончания цикла ввода нажмите Esc):");
        try
        {
            string st = ReadFromConsole();
            if (st == "out")
            {
                break;
            }
            int number = Convert.ToInt32(st);
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = number;
        }
        catch
        {
            Console.WriteLine("Ошибка преобразования числа");
        }
    }
}
