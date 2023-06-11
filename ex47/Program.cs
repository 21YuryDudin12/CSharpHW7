//Задайте двумерный массив размером m×n, заполненный 
//случайными вещественными числами

int nRows = 3;
int mColumns = 4;

double[,] array = GetArray(nRows, mColumns, 0,10);
PrintArray(array);


double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m,n];
    Random random = new Random();
    for (int i = 0; i<m; i++)
    {
        for (int j = 0; j<n; j++)
        {
            result[i,j] = random.NextDouble() * (maxValue - minValue) + minValue;
            result[i,j] = Math.Round(result[i,j],1);
        }
    }
    return result;

}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i<inArray.GetLength(0); i++)
    {
        for (int j = 0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}