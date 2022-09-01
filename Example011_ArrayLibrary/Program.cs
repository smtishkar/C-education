void FillArray(int[] collection)        // void метод ни чего не возвращает и поэтому не надо ни где писать return
{
    int lengh = collection.Length;
    int index = 0;
    while (index < lengh)
    {
        collection[index] = new Random().Next (1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int possition = 0;
    while(possition < count)
    {
        Console.WriteLine(col[possition]);
        possition++;
    }
}


int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;     // Если значение не будет найдено тогда будет отображаться -1. Нужно чтобы не совпадало с индексом 0

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int [10];     //команда для создания массива с нужным количеством элементов


FillArray(array);
array[4] = 4;       // добавили ради эксперемента
array[6] = 4;       // добавили ради эксперемента


PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);