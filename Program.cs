public class FindDuplicateElements
{
    public static void Main(string[] args)
    {
        //создание массива
        int[] array = { 1, 5, 3, 7, 5, 9, 2 };

        Console.WriteLine("Исходный массив: " + string.Join(" ", array));

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                //проверка, является ли текущий элемент внешнего цикла array[i] равным текущему элементу внутреннего цикла array[j].
                if (array[i] == array[j])
                {
                    Console.WriteLine($"\nПовторяющийся элемент: {array[i]}");
                    Console.WriteLine($"Первая позиция: {i + 1}, Вторая позиция: {j + 1}");
                    return;
                }
            }
        }
        Console.WriteLine("\nДубликаты не найдены.");
    }
}