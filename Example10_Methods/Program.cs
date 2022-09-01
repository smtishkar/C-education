int[] array = { 1, 22, 23, 4, 55, 16, 70, 4 };

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;                  // из-за того, что мы указали тут break, программы закончится после нахождения первого элемента
    }
    index++;
}