Console.Clear();
double[,] value = new double[2, 2];
double[] crossPoint = new double[2];

void InputValue()
{
    for (int i = 0; i < value.GetLength(0); i++)
    {
        Console.Write($"Введите значения {i+1} уравнения (y = k * x + b):");
        System.Console.WriteLine();
        for (int j = 0; j < value.GetLength(1); j++)
        {
            if(j == 0) Console.Write($"Введите значения k: ");
            else Console.Write($"Введите значения b: ");
            value[i,j] = int.Parse(Console.ReadLine()!);
        }
    }
}

double[] Decision(double[,] value)
{
    crossPoint[0] = (value[1,1] - value[0,1]) / (value[0,0] - value[1,0]);
    crossPoint[1] = crossPoint[0] * value[0,0] + value[0,1];
    return crossPoint;
}

void ValueComparison(double[,] value)
{
    if (value[0,0] == value[1,0] && value[0,1] == value[1,1]) 
    {
        Console.Write($"\nПрямые пересекаются");
    }
    else if (value[0,0] == value[1,0] && value[0,1] != value[1,1]) 
    {
        Console.Write($"\nПрямые параллельны");
    }
    else 
    {
        Decision(value);
        Console.Write($"пересечение: ({crossPoint[0]}, {crossPoint[1]})");
    }
}

InputValue();
ValueComparison(value);