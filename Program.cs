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
    array[i] = rand.Next(0,9);
   }
//Вывод массива 
            Console.WriteLine();
            Console.Write("Исходный массив - ");
            for (int i = 0; i < array.Length; i++)
            Console.Write(array[i]);
            Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
if array[i] % 2 = 1
{
  int      
}
}