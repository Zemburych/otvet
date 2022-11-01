// Написать программу, которая преобразует массив целых чисел в массив чисел, в котором находятся только четные числа
// array [5, 8, 3....]

Console.Clear();
Console.WriteLine("Ввелите количество элементов массива  ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];
// Рандомный ввод массива
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
     {
      array[i] = rand.Next(1,9);
     }
//Вывод массива 
            Console.Write("Исходный массив - ");
            for (int i = 0; i < array.Length; i++)
            Console.Write(" " + array[i]);
            Console.WriteLine();
// вычисление количества четных элементов
    int index=0;
    for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 == 0)
    index++;
    Console.Write("количество четных элементов - " + index);
// создаем новый массив
int[] NewArray = new int[index];
int index2=0;
    for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        NewArray[index2] = array[i];
        index2++;
    }
}
Console.WriteLine();
// вывод нового массива
 Console.Write("Новый массив - ");
            for (int j = 0; j < index; j++)
            Console.Write(" " + NewArray[j]);
 