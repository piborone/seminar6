// // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 3

int[] Massiv(int numbersA) // заполнение массива с клавиатуры
{
            int[] array = new int[numbersA]; 
            Console.WriteLine("Введите числа: ");
            for(int i = 0; i < numbersA; i++)
           
            {
            array[i] = Convert.ToInt32(Console.ReadLine());    
            }
                                             
    return array;
}

Console.WriteLine("C каким кол-во цифр планируете работать? ");
int a = Convert.ToInt32(Console.ReadLine());
int[] d = Massiv(a);
Console.WriteLine($"[{String.Join(", ", d)}]");
int sum = 0;
for (int i = 0; i < d.Length; i++)
{
    if (d[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine($"количество значений больше 0 = {sum}");
