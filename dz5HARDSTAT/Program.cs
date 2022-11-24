// Задайте массив случайных целых чисел. 
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.

Console.WriteLine("Введите количество элементов массива: ");// Введение числа элементов массива
int index;
if (!int.TryParse(Console.ReadLine()!, out index))
{
    Console.WriteLine("Неверный ввод");
    return;
}
int[] randomNumbers = new int[index];// Основная часть программы. Создание массива для расчетов
string[] separateArray = new string[5]; // Создание массива для вывода расчетных значений. 5 - заранее известное кол-во расчетных значений.

FillArray(randomNumbers);

int max = randomNumbers[0]; int min = randomNumbers[0]; // Объявление перменных после заполнения массива для того чтобы
int indmin = 0; int indmax = 0; float average = 0; // В минимальных значениях не писались нули
                                                   // Это важно если в заданных для массива числах нет отрицательных.
PrintArray(randomNumbers);
CountingDigits(randomNumbers);
Sep(separateArray);
Median(randomNumbers);

void Sep(string[] separateArray)// Функция заполнения выходного массива массива.
{
    separateArray[0] = "Максимальный элемент массива = " + max; separateArray[1] = "Индекс максимального элемента массива = " + indmax;
    separateArray[2] = "Минимальный элемент массива = " + min; separateArray[3] = "Индекс минимального элемента массива = " + indmin;
    separateArray[4] = "Среднее арифметичечское массива = " + average;
    for (int i = 0; i < separateArray.Length; i++)
    {
        Console.WriteLine(separateArray[i] + " ");
    }
    Console.WriteLine();
}
void FillArray(int[] randomNumebrs)// Заполнение массива случайными целыми числами
{
    Random rnd = new Random();
    for (index = 0; index < randomNumebrs.Length; index++)
    {
        randomNumebrs[index] = rnd.Next(-100, 100);
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
void CountingDigits(int[] randomNumbers) // Расчет значений для выходного массива типа string
{
    for (index = 0; index < randomNumbers.Length; index++)
    {
        average += randomNumbers[index]; //Сюда не пишется функция Sum т.к она целочисленная...
        if (randomNumbers[index] > max)  // А это значение больше подходит под тип float или double
        {
            max = randomNumbers[index];
            indmax = index;
        }
        if (randomNumbers[index] < min)
        {
            min = randomNumbers[index];
            indmin = index;
        }
    }
    average = average / index;           // Не знаю такой же функции для float или double. Поэтому все ручками через доп итерацию.....
}
void Median(int[] randomNumbers)// Расчет медианы изначального массива
{
    int[] med = randomNumbers;
    Array.Sort(med); // Для расчета медианы сначла надо массив упорядочить по возрастанию.
    int medi = 0;
    if (med.Length % 2 != 0)
    {
        medi = med[med.Length / 2];
    }
    else
    {
        medi = (med[med.Length / 2] + med[(med.Length / 2) - 1]) / 2;
    }
    Console.WriteLine("Медиана: " + medi);
}
