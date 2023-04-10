// Вид 1

// void Method1()
// {
//     Console.WriteLine("Автор Василий");
// }
// Method1();


// Вид2

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
//Method2(msg: "Текст сообщения"); //Может писаться без msg:

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(msg: "Текст", count: 4); // Может писаться без синих надписей, но именно в таком порядке. С надписями же порядок не имеет значения


// Вид3

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

// Вид4
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "qwerty");
// Console.WriteLine(res);

// string Method4(int count, string text)
// {
//     string result = String.Empty; //String.Empty - Пустая строка
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "qwerty");
// Console.WriteLine(res);


// for (int i = 1; i < 10; i++)
// {
//     for (int j = 1; j < 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

//===== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// Ясна ли задача?

string txt = "Я думаю, - Сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винецгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";


string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else  result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replase(txt, ' ', '|');
Console.WriteLine(newText);

newText = Replase(newText, 'к', 'К');
Console.WriteLine(newText);

// int[] arr = {2, 3, 4, 9, 2, 7, 4, 8, 6};

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSortUp(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }

//         int temporary1 = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary1;

//     }
// }

// void SelectionSortDown(int[] array)
// {
//     for (int k = 0;  k < array.Length - 1; k++)
//     {
//         int maxPosition = k;

//         for (int l = k + 1; l < array.Length; l++)
//         {
//             if (array[l] > array[maxPosition]) maxPosition = l;
//         }
        
//         int temporary2 = array[k];
//         array[k] = array[maxPosition];
//         array[maxPosition] = temporary2;

//     }
// }





// PrintArray(arr);
// SelectionSortUp(arr);
// PrintArray(arr);
// SelectionSortDown(arr);
// PrintArray(arr);