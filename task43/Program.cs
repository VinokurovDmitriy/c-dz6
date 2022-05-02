//найти точку пересечения прямых заданных уравнениями y = k1 * x + b1 и y = k2 * x + b2
int[,] variables = new int[2, 2];
string variableName;
for (int i = 0; i < variables.GetLength(0); i++)
{
    for (int j = 0; j < variables.GetLength(1); j++)
    {
        if (j == 0) variableName = "b";
        else variableName = "k";
        Console.Write($"Введите зачение {variableName}{i + 1} = ");
        variables[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
double x = (double) (variables[1, 0] - variables[0, 0]) / (variables[0, 1] - variables[1, 1]);
double y = (double) (variables[1, 0] * variables[0, 1] - variables[0, 0] * variables[1, 1]) / (variables[0, 1] - variables[1, 1]);
Console.WriteLine($"Точка пересечения прямых ({x}, {y})");
