int[] array = {11, 12, 23, 53, 45, 64, 74, 45, 25};

int n = array.Length;
int find = 45;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}