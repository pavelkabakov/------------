Console.Clear();
Console.Write("Введите число: ");
string number = Console.ReadLine()!;
int result = 0;
for (int i = 0; i < number.Length; i++)
{
    result += int.Parse(number[i].ToString());
}
Console.WriteLine(result);


// Console.Clear();
// Console.Write("Введите размеры массива: ");
// int[] size = Console.ReadLine()!.Split().Select(i => int.Parse(i)).ToArray();
// Console.WriteLine(size[0] + size[1]);