Console.Write("Сколько элементов Вы хотите ввести? ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string ArrayPart = Convert.ToString(Console.ReadLine());
    array1[i] = ArrayPart;
}
string[] array2 = new string[size];
int num = 3;
int count = 0;
