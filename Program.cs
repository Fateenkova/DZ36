// задача 36. Задайте одномерный массив заполненный случайными числами.Найдите сумму этих элементов, стоящих на нечетных позициях.
int[] array = new int[4];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 8);
    Console.WriteLine($"{array[i]}");
    if (i % 2 == 1)
    {
        sum = sum + array[i];
    }
}

Console.Write(sum);