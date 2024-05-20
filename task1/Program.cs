// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3
// 4 3 4 1 =>
// 2 9 5 4
// 4 3 16 3
// 4 3 4 1
// 4 9 25 4

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) //создаем функцию для создания двумерного массива
{

    int[,] matrix = new int[rows, columns]; // задаем двумерный массив   


    Random rnd = new Random();              // вводим генератор случайных чисел

    for (int i = 0; i < matrix.GetLength(0); i++) //цикл заполнения строк массива
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// цикл заполнения элекментов массива
        {
            matrix[i, j] = rnd.Next(min, max);   //заполнения случайными  числами методом Next
        }

    }

    return matrix;       //возврат созданного массива 
}

void PrintMatrix(int[,] matrix) //создаем безвозратную функцию для вывода массива на консоль
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        //Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}"); //,5 количество пробелов между числами
        }
        //Console.WriteLine(" |");
        Console.WriteLine(); // переключение строк
    }
}

void ElemEvenIndexesToSquare(int[,] matrix) //создаем функцию  по поиску четного индекса массива и
{                                           //в квадрат числа с данными индексами
    for (int i = 0; i < matrix.GetLength(0); i += 2) //индекс строк идет только по четным
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2) //индекс столбцов идет только по четным
        {
            //if (i % 2 == 0 && j % 2 == 0) //ищем четные индексы массива
            //{
            matrix[i, j] *= matrix[i, j];  //возводим в квадрат число массива с четными индексами
            //}
        }
    }
}

int[,] array2d = CreateMatrixRndInt(5, 4, 1, 10); // вводим параметры массива в функцию
PrintMatrix(array2d);  //выводим двумерный массив

Console.WriteLine(); //переключаем строку

ElemEvenIndexesToSquare(array2d); //вводим параметр массива для функции с возведенными в квадрат элементами
PrintMatrix(array2d);     //выводим этот массив