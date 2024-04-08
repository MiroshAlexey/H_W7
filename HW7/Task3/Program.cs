// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.




int[] array = { 1, 7, 65, 0, 11, 87 };
ReversOutputItemArray(array, array.Length - 1);
void ReversOutputItemArray(int[] array, int index)
{
    if (index + 1 == 0)
    {
        return;
    }
    Console.Write(array[index] + " ");
    ReversOutputItemArray(array, index - 1);
    return;
}