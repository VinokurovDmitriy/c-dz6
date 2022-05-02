//Пользователь вводит с клавиатуры N чисел. Подсчитать количество положительных чисел
Console.WriteLine("Введите количество чисел, которое хотите ввести");
int n = Convert.ToInt32(Console.ReadLine());
int countPositive = 0;
for(int i = 0; i < n; i++)
{
    Console.WriteLine($"Введите {i + 1} число из {n}");
    if(Convert.ToInt32(Console.ReadLine()) > 0) countPositive++;
}
Console.WriteLine($"Вы ввели {countPositive} чисел больше нуля");

