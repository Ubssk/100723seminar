// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] array = new int[10];
int elems = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0)
    {
        elems++;
    }
}
Console.WriteLine($"Количество элементов больше нуля: {elems}");

// Вариант 2
// Ввод элементов массива одной строкой через пробел, для окончания ввода Enter:

// int[] array = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();;
// int elems = 0;
// Console.WriteLine(array);
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         elems++;
//     }
// }
// Console.WriteLine($"Количество элементов больше нуля: {elems}");