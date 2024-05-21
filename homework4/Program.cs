//разворот строки  наоборот


string strNew = "Hello my friend "; //создание строки

string[] strNewSplit = strNew.Split(); //["Hello" "my" "friend"]  создание массива  для метода  разворота Split

string res = "";                                  //создаем новую строку  для размещение разворотной строки
for (int i = strNewSplit.Length - 1; i >= 0; i--) //цикл разворота
{
    res += strNewSplit[i] + " ";      // записываем  в новую  строку слова, разворот по пробелам
}

Console.WriteLine(res); // вывод  новой строки