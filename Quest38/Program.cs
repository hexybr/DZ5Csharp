// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Введите количество элементов массива: ");// Введение числа элементов массива
int index;
if (!int.TryParse(Console.ReadLine()!, out index))
{
    Console.WriteLine("Неверный ввод");
    return;
}
float[] realNumbers = new float[index];// Основная часть программы. Создание массива вещественных чисел
FillArray(realNumbers);
PrintArray(realNumbers);
DifferenceMaxMin(realNumbers);

void FillArray(float[] realNumbers)// Заполнение массива случайными числами
{
    Random rnd = new Random();
    for (index = 0; index < realNumbers.Length; index++)
    {
        realNumbers[index] = rnd.Next(0, 1000);
    }

}
void PrintArray(float[] realNumbers)// Вывод получившегося массива
{
    Console.WriteLine("Полученный массив: ");
    for (index = 0; index < realNumbers.Length; index++)
    {
        Console.Write(realNumbers[index] + " ");
    }
    Console.WriteLine();
}
void DifferenceMaxMin(float[] num)// Функция подсчета разницы между максимальным и минимальным элементом массива
{
    float min = num[0];
    float max = num[0];
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > max)
            max = num[i];
        if (num[i] < min)
            min = num[i];
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {max - min}");
}

