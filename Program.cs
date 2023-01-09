//Task 47
Console.WriteLine("Task 47");
int readNum(){
    Console.WriteLine("Введите размер массива: ");
    return int.Parse(Console.ReadLine());
}
double [,] massiv(int m, int n)
{
    Random rnNum= new Random();
    double [,] newMas=new double [m, n];
        for (int i=0; i<m; i++)
        {
            for (int j=0; j<n; j++)
            {
                newMas[i,j]=Math.Round(rnNum.NextDouble()*100, 2);
            }
        }
        return newMas;
}
 int m=readNum();
 int n=readNum();
 double [,] mas47=massiv(m,n);
for (int i=0; i<m; i++) 
{
    for (int j=0; j<n; j++)
    {
        Console.Write($"{mas47[i,j]} ");
    }
     Console.WriteLine();
}

//Task 50
Console.WriteLine("Task 50");
int k=readNum();
int d=readNum();
double [,] mas50=massiv(k,d);
for (int i=0; i<k; i++) 
{
    for (int j=0; j<d; j++)
    {
        Console.Write($"{mas50[i,j]} ");
    }
     Console.WriteLine();
}
Console.WriteLine("Введите элемент массива, который необходимо отобразить в формате [x,y], начиная с нуля: ");
string numEl=Console.ReadLine();
numEl=numEl.Replace("[", "");
numEl=numEl.Replace("]", "");
int[] numbers = numEl.Split(',').Select(snum => int.Parse(snum)).ToArray();
if (numbers[0]>k | numbers[1]>d)
{
    Console.WriteLine("Такого элемента не существует");
} else
{
     Console.WriteLine($"Элемент равен = {mas50[numbers[0],numbers[1]]}");
}

// Task 52
Console.WriteLine("Task 52");
 int q=readNum();
 int w=readNum();
double [,] mas52=massiv(q,w);
double [] mas78=new double [w];
for (int i=0; i<q; i++){
    for (int j=0; j<w; j++){
        Console.Write($"{mas52[i,j]} ");
        mas78[j]=mas78[j]+mas52[i,j];
    }
     Console.WriteLine();
}
Console.WriteLine("Среднее арифметическое столбцов массива равно:");
for (int i=0; i<w; i++)
{
     mas78[i]= mas78[i]/q;
     Console.Write($"{mas78[i]} ");
}



// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.