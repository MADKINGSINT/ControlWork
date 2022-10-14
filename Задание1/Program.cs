Console.Write("Сколько элементов Вы хотите ввести? ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[size];
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите элемент массива: ");
    string ArrayPart = Convert.ToString(Console.ReadLine());
    array1[i] = ArrayPart;
}
string[] array2 = new string[size];
int num = 3;
int count = 0;
for (int j = 0; j < size; j++)
{
    if (array1[j].Length <= num)
    {
        array2[count] = array1[j];
        count++;
    }
}
Console.WriteLine();
PrintArray(array2);
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}