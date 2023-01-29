// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Write("Сколько элементов Вы хотите ввести? ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = new string[size];
for (int i = 0; i < size; i++)
{
    System.Console.WriteLine($"Ввведите {i + 1} элемент");
    string el = Convert.ToString(Console.ReadLine());
    array[i] = el;
}


string[] arrayword = new string[size];
int count = 0;
for (int j = 0; j < array.Length; j++)
    if (array[j].Length <= 3)
    {
        {
            arrayword[count] = array[j];
            count++;
        }
    }
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();
PrintArray(arrayword);
