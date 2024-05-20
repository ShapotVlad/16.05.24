// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.
// Пример
// 2 3 4 3
// 4 3 4 1 => 2 + 3 + 5 = 10
// 2 9 5 4

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) // смотри task1 
{
    //       0        1     
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

void PrintMatrix(int[,] matrix)                               //смотри task1 

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

int SumMainDiagonal(int[,] matrix)     //создаем возвратную функцию для подсчета суммы элемнов главной диогонали
{
    int sum = 0;  //вводим переменную суммы

    // int minSize = matrix.GetLength(0);
    // if(matrix.GetLength(1) < minSize)
    // {
    //     minSize = matrix.GetLength(1);
    // }

    for (int d = 0; d < matrix.GetLength(0) && d < matrix.GetLength(1); d++) //создаем цикл для подсчета суммы главной диоганали
    {
        sum = sum + matrix[d, d]; // sum += matrix[i, i];
    }
    return sum;
}

int[,] array2d = CreateMatrixRndInt(4, 5, 1, 10); // создаем двумерный массив и вводим данные для  функции  
PrintMatrix(array2d); //выводим на консоль двумерный массив

Console.WriteLine();

int result = SumMainDiagonal(array2d); //создаем переменную для функции подсчета суммы  диоганали
Console.Write(result); //выводим результат



