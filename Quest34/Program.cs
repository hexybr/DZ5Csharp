// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Введите количество элементов массива: ");// Введение числа элементов массива
int index;
if (!int.TryParse(Console.ReadLine()!, out index))
{
    Console.WriteLine("Неверный ввод");
    return;
}
int[] randomNumbers = new int[index];// Основная часть программы. Создание массива
FillArray(randomNumbers);// Выполнение необходимых действий
PrintArray(randomNumbers);
EvenCounter(randomNumbers);

void FillArray(int[] randomNumebrs)// Заполнение массива случайными положительными трехзначными числами
{
    Random rnd = new Random();
    for (index = 0; index < randomNumebrs.Length; index++)
    {
        randomNumebrs[index] = rnd.Next(100, 1000);
    }

}
void PrintArray(int[] randomNumbers)// Вывод получившегося массива
{
    Console.WriteLine("Полученный массив: ");
    for (index = 0; index < randomNumbers.Length; index++)
    {
        Console.Write(randomNumbers[index] + " ");
    }
    Console.WriteLine();
}
void EvenCounter(int[] rand)// Счетчик четных элементов массива
{
    int count = 0;
    for (int i = 0; i < rand.Length; i++)
    {
        if (rand[i] % 2 == 0) count++;
    }
    Console.WriteLine("Количество четных чисел в массиве = " + count);
}