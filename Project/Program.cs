// Из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символа.//

/*string text = "Должен вам сказать, что, мы вовсе не хотим завоевывать никакой Космос."   
            + "Мы хотим расширить Землю до его границ. Мы не знаем, что делать с иными"
            + "мирами. Нам не нужно других миров. Нам нужно зеркало… Мы бьёмся над"
            + "контактом и никогда не найдём его. Мы в глупом положении человека,"
            + "рвущегося к цели, которой он боится, которая ему не нужна. Человеку нужен человек!";

string[] text2 = text.Split(' ', '.', ',', '!'); 

foreach (var word in text2)  
{
    if((word.Length<=3)&&(word.Length>=1))
    {
    Console.Write($"{word+", "}"); 
    }
}*/


string[] arraywords = new string[11]{"Должен", "вам", "сказать", "что", "мы", "вовсе", "не", "хотим", "завоевывать", "никакой", "Космос"};
string[] arraywords2 = new string[arraywords.Length];
ArrayResult(arraywords, arraywords2);
PrintArray(arraywords2);

void ArrayResult (string[] arraword, string[] arraword2)
{
    int index = 0;
    for(int i = 0; i<arraword.Length; i++)
    {
        if((arraword[i].Length<=3)&&(arraword[i].Length>=1))
        {
         arraword2[index]=arraword[i];
         index++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]} ");
    }
    Console.WriteLine();
}