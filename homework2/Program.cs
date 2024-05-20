// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные.

// 21:46
// “aBcD1ef!-” => “abcd1ef!-”

string UpperToLower(string str)
{
    string strResult = string.Empty;

    for (int i = 0; i < str.Length; i++)
    {
        if (char.IsUpper(str[i]))
        {
            strResult += char.ToLower(str[i]);
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








