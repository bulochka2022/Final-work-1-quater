// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма.

//Метод проверяет длину элемента массива и если она <=3, записывает элемент в новый массив
void ShortArray(string[] array, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        newArray[count] = array[i];
        count++;
        }
    }
}

//Метод печати массива
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


string[] array = new string[4] {"hello", "2", "world", ":-)"};
string[] newArray = new string[array.Length];
ShortArray(array, newArray);
PrintArray(newArray);