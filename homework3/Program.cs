//Задайте произвольную строку. Выясните, является ли она палиндромом.


Console.Write("Введите строку: ");
        string input = Console.ReadLine(); // ввод строки

        bool isPalindrome = IsPalindrome(input); // создаем метод IsPalindrome

        if (isPalindrome)    // вывод на консоль
        {
            Console.WriteLine("Строка \"{0}\" является палиндромом.", input);
        }
        else
        {
            Console.WriteLine("Строка \"{0}\" не является палиндромом.", input);
        }
    

   static bool IsPalindrome(string str)
    {
        // Удаляем пробелы и приводим к нижнему регистру
        str = str.Replace(" ", "").ToLower();

        for (int i = 0; i < str.Length / 2; i++)
        {
            if (str[i] != str[str.Length - i - 1]) //если символы не эквивалент не эквиваленты
            {
                return false;
            }
        }

        return true;
    }

