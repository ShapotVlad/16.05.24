// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

int CountVowels(string str) //создаем метод(функцию) для подсчета главсных в веденной строке с консоли
{
    string vowels = "aeiouy"; //создали переменную строки гласных
    int count = 0;            //создали переменную для подсчета гласных 
    for (int i = 0; i < str.Length; i++) // цикл перебора строки
    {
        for (int j = 0; j < vowels.Length; j++) //цикл  перебора  переменной строки гласной
        {
            if (str[i] == vowels[j]) //сравниваем элементы  строки введенной и строки гласных
            {
                count++;  //если в строке есть гласные увеличиваем счетчик
            }
        }
    }
    return count; //возврат переменной счетчика в функцию
}

Console.WriteLine("Напишите слово: "); //ввод слова
string start = Console.ReadLine(); // ввод
Console.WriteLine($"В слове {CountVowels(start)} гласных");//вызов функции CountVowels(string str) и вывод счетчика

Console.WriteLine();//разрыв строки

//второй метод

int QuantityVowels(string str)
{
    string vowels = "aeiouy";
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (vowels.Contains(str[i])) //подсчет гласных методом  Contains
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Напишите слово: ");
string rite = Console.ReadLine();
Console.WriteLine($"В слове {QuantityVowels(rite)} гласных");