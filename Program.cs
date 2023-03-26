
string[] array = new string[5]{"cwasc", "ff", "sdf", "dddd", "1"}; // задаем массив

Console.WriteLine($"[\"{String.Join("\"; ", array)}\"]");
Console.WriteLine($"[\"{String.Join("\"; ", GetArrayResstrElem(array, 3))}\"]");


/// <summary>
/// Принимает массив строк и число, удаляет из массива все элементы, у которых
/// количество символов больше переданного числа
/// </summary>
/// <param name="arr">Массив строк</param>
/// <param name="n">Число, ограничивающее максимальное количество символов строки</param>
/// <returns>Массив строк без элементов исходного с количеством символов больше n</returns>
string[] GetArrayResstrElem(string[] arr, int n)
{
    int resultSize = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= n) resultSize++;
    }

    int k = 0;
    string[] resultArr = new string[resultSize];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= n)
        {
            resultArr[k] = arr[i];
            k++;
        }
    }
    return resultArr;
}

