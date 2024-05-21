// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

char[] StringToCharArray( string s) //создаем метод(функцию) для перевода символов строки string s в массив символов char[]
{
    char[] strArray = new char[s.Length]; //создаем массив strArray 
    for (int i = 0; i < s.Length; i++)  //цикл  по переводу строки в массив strArray[i]
    {
        strArray[i] = s[i];
    }
return strArray; //ввозврат  в массив
}

void PrintArray(char[] array)   //создаем метод(функцию) вывода массива на консоль
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, "); //через запятую
        else
            Console.Write($"{array[i]}"); //без запятой
    }
     Console.Write("]");
}
Console.WriteLine("введите строку"); //создаем ввод строки
string str = Console.ReadLine (); //ввод строки

char [] resArray = StringToCharArray (str); //создаем массив  и вызываем функцию 

PrintArray (resArray); //выводим на печать
