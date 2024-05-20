// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) //смотри task1 
{

    int[,] matrix = new int[rows, columns]; // 3x4
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)                              //смотри task1 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

void PrintArray(double[] array)                   //создали вещественный тип функции для вывода одномерного массива
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) //цикл вывода одномерного массива
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]:F2}, "); //элементы массива через запятую и количество цифр после запятой :F2
        else
            Console.Write($"{array[i]:F2}");    //после последнего элемента запятая не ставится и количество цифр после запятой
    }
     Console.Write("]");
}

double[] GetAverageArrayRows(int[,] matrix)//создали вещественный тип функции  для подсчета суммы средних чисел  строк двумерного массива
{
    double[] array = new double[matrix.GetLength(0)]; //вводим вещественный одномерный массив
    for(int i = 0; i < matrix.GetLength(0); i++)  //цикл по строкам
    {
        int sum = 0;                                  // вводим переменную для подсчета семмы средних элементов 
        for(int j = 0; j < matrix.GetLength(1); j++) //цикл по столбцам
        {
            sum += matrix[i, j];  // сумма чисел строки
        }
        array[i] = (double)sum / matrix.GetLength(1);  //среднее число строки
    }
    return array; //возврат одномерному массиву
}

int[,] array2d = CreateMatrixRndInt(4, 4, 1, 10);  //создание массива для ввода данных в функцию  двумерного массива
PrintMatrix(array2d); //вывод на консоль двумерных массив


Console.WriteLine();

double[] result = GetAverageArrayRows(array2d); //создание вещественной переменной  для функции  подсчета суммы
PrintArray(result); //вывод результата