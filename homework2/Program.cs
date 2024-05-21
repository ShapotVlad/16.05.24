// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные.

// 21:46
// “aBcD1ef!-” => “abcd1ef!-”

string UpperToLower(string str)                     //создаем метод(функцию) перевода символов введенной строки  в строку с буквами строчного регистра
{
    string strResult = string.Empty;                //создаем строку для переноса в него символов

    for (int i = 0; i < str.Length; i++)            //цикл  прохода  введенной строки
    {
        if (char.IsUpper(str[i]))                   // метод определяет  содержит ли строка заглавгые буквы
        {
            strResult += char.ToLower(str[i]);      // преобразует заглавные в прописные буквы и формирует строку
        }
        else
        {
            strResult += str[i];
        }
    }
    return strResult;
}


string str = "aBcD1ef!TRUnbhWER-";
string strResult = UpperToLower(str);
Console.WriteLine(strResult);








