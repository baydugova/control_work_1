Console.WriteLine("Задайте элементы массива через запятую: ");
string[] array = Console.ReadLine().Split(',');

Console.WriteLine($"Новый массив: {string.Join(", ", NewArray(array))}");

int FilterArray(string[] array) //Фильтрация массива и возврат количества элементов, согласно условию
{
    int countArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            countArray++;
        } 
    }
    return countArray;
}

string[] NewArray(string[] array) //создаем новый массив, согласно условию
{
    string[] newArray = new string[FilterArray(array)];
    int size = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[size] = array[i];
            size++;
        }
    }
    return newArray; //возврат нового массива
}




