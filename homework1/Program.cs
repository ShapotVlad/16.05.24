


    
        // Создаем двумерный массив символов
        char[,] charArray = new char[,]
        {
            { 'H', 'e', 'l', 'l', 'o' },
            { 'W', 'o', 'r', 'l', 'd' }
        };

        // Создаем строку из массива символов
        string result = new string(GetCharArrayAs1D(charArray));

        // Выводим результат
        Console.WriteLine("Результирующая строка: " + result);
    

    // Метод для преобразования двумерного массива символов в одномерный
    static char[] GetCharArrayAs1D(char[,] charArray)
    {
        int rows = charArray.GetLength(0);
        int cols = charArray.GetLength(1);
        char[] result = new char[rows * cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i * cols + j] = charArray[i, j];
            }
        }

        return result;
    }

