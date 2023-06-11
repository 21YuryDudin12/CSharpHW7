//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

int rows = Prompt("Введите колличество строк массива: ");
int columns = Prompt("Введите колличество столбцов массива: ");

double[,] array = GetArray(rows, columns, 0,10);
PrintArray(array);
FindColumnAvg(array, rows, columns);

int Prompt (string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double[,] GetArray( int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m,n];
     Random random = new Random();
    for (int i = 0; i<m; i++)
    {
        for (int j = 0; j<n; j++)
        {
            result[i,j] = random.NextDouble() * (maxValue - minValue) + minValue;
            result[i,j] = Math.Round(result[i,j],0);
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

// с этим методом было реально сложно, но я смог!))
void FindColumnAvg(double[,] Farray, int row, int col)
{
    double[] resArray = new double[col];
    for (int i = 0; i < Farray.GetLength(1); i++)
    {
        for (int j = 0; j < Farray.GetLength(0); j++)
        {
            resArray[i] = resArray[i] + Farray[j, i];
        }
        resArray[i] = resArray[i] / row;
        Console.WriteLine($"Среднее арифметическое столбца {i + 1} = {resArray[i]}");
    }
}