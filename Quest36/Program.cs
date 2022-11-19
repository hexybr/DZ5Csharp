// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
Console.WriteLine("Введите количество элементов массива: ");// Введение числа элементов массива
int index;
if (!int.TryParse(Console.ReadLine()!, out index))
{
    Console.WriteLine("Неверный ввод");
    return;
}
int[] blessrnd = new int[index];// Основная часть программы. Создание массива
FillArray(blessrnd);
PrintArray(blessrnd);
Counter(blessrnd);

void FillArray(int[] blessrnd)// Заполнение массива случайными числами
{
    Random rnd = new Random();
    for (index = 0; index < blessrnd.Length; index++)
    {
        blessrnd[index] = rnd.Next(-1000, 1000);
    }

}
void PrintArray(int[] blessrnd)// Вывод получившегося массива
{
    Console.WriteLine("Полученный массив: ");
    for (index = 0; index < blessrnd.Length; index++)
    {
        Console.Write(blessrnd[index] + " ");
    }
    Console.WriteLine();
}
void Counter(int[] rnd)// Функция подсчета суммы элементов с нечетным индексом
{
    int count = 0;
    for (int i = 1; i < rnd.Length; i = i + 2)
    {
        count = count + rnd[i];
    }
    Console.WriteLine("Сумма элементов массива с нечетным индексом = " + count);
}
