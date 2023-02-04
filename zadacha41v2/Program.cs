// // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 3
// void PrintArray (int [] array, string [] string1)
// {
//   for (int i = 0; i < array.Length; i++)
//   {
//   array[i] = Convert.ToInt32(string1[i]);
//   Console.Write (array[i]+"  ");
//   }
// Console.WriteLine();
// }

Console.Write("введите необходимое кол-во цифры(для раздедения используем пробел): ");
string str = Console.ReadLine();
string[] numbers = new string[str.Length];
int peremen = 0;
for(int i = 0; i < numbers.Length; i++)
{
    if(str[i] == ' ')
    {
        peremen++;
    }
    else
    {
        numbers[peremen] = numbers[peremen]+$"{str[i]}";
    }
}
peremen++;

int[] newnumbers = new int[peremen];
 for (int i = 0; i < newnumbers.Length; i++)
  {
  newnumbers[i] = Convert.ToInt32(numbers[i]);
  }
  Console.WriteLine($"[{String.Join(", ", newnumbers)}]");
int sum = 0;
for (int i = 0; i < newnumbers.Length; i++)
{
    if (newnumbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine($"количество значений больше 0 = {sum}");
