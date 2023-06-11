//Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.

int rows = Prompt("Введите колличество строк массива: ");
int columns = Prompt("Введите колличество столбцов массива: ");

int[,] array = GetArray(rows, columns, 0,10);
PrintArray(array);

Console.WriteLine("!!!Индекс элемента начинается с единицы!!!");
Console.WriteLine("Введите номер строки(начиная с еденицы): ");
int fx = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца(начиная с еденицы): ");
int fy = int.Parse(Console.ReadLine());

FindElement(array, fx, fy);

int Prompt (string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for (int i = 0; i<m; i++)
    {
        for (int j = 0; j<n; j++)
        {
            result[i,j] = new Random().Next(minValue,maxValue);
        }
    }
    return result;

}

void PrintArray(int[,] inArray)
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

void FindElement (int[,] Farray, int x, int y)
{
    int resNum = 0;
    for (int i = 0; i<Farray.GetLength(0); i++)
    {
        for (int j = 0; j<Farray.GetLength(1); j++)
        {
            if (i==x-1 && j==y-1)
            {
                resNum = Farray[i,j];
            }
        }
    }
    if (x>Farray.GetLength(0) || y>Farray.GetLength(1) )
    {
        Console.WriteLine("Элемента с таким номером нет");
    }
    else
    {
         Console.WriteLine("Искомый элемент: "+resNum);
    }
}