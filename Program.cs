Console.WriteLine("Введите размерность квадратой матрицы");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапозон чисел для матриц через пробел");
string[] input = Console.ReadLine().Split(" ");
int a = Convert.ToInt32(input[0]);
int b = Convert.ToInt32(input[1]);
int[,] matex = new int[N,N];

static int[,] zapolnenie(int a, int b,int N)
{
    int[,] matr = new int[N,N];
    int rows = matr.GetUpperBound(0) + 1;
    int columns = matr.Length / rows;
    Random r = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            
            matr[i, j] = r.Next(a, b);
        }

    }
    return matr;
}

static int[,] minus(int[,] a, int[,] b, int N)
{
    int[,] answ = new int[N,N];
    int rows = a.GetUpperBound(0) + 1;
    int columns = a.Length / rows;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            answ[i,j] = a[i, j] - b[i,j];
        }

    }
    return answ;
}

static int[,] plus(int[,] a, int[,] b, int N)
{
    int[,] answ = new int[N,N];
    int rows = a.GetUpperBound(0) + 1;
    int columns = a.Length / rows;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            answ[i,j] = a[i, j] + b[i,j];
        }

    }
    return answ;
}
int[,] matr1 = zapolnenie(a,b,N);
int[,] matr2 = zapolnenie(a,b,N);
int[,] matrplus = plus(matr1,matr2,N);
int[,] matrminus = minus(matr1,matr2,N);
Console.WriteLine("Матрица 1");
int rows1 = matr1.GetUpperBound(0) + 1;
int columns1 = matr1.Length / rows1;
for (int i = 0; i < matr1.GetLength(0); i++)
{
    for (int j = 0; j < matr1.GetLength(1); j++)
        Console.Write("{0} ", matr1[i, j]);
    Console.WriteLine();
}
Console.WriteLine("Матрица 2");
int rows2 = matr2.GetUpperBound(0) + 1;
int columns2 = matr2.Length / rows2;
for (int i = 0; i < matr2.GetLength(0); i++)
{
    for (int j = 0; j < matr2.GetLength(1); j++)
        Console.Write("{0} ", matr2[i, j]);
    Console.WriteLine();
}
Console.WriteLine("Сумма матриц");
int rowsmin = matrplus.GetUpperBound(0) + 1;
int columnsmin = matrplus.Length / rowsmin;
for(int i = 0; i < matrplus.GetLength(0); i++)
{
    for (int j = 0; j < matrplus.GetLength(1); j++)
        Console.Write("{0} ", matrplus[i, j]);
    Console.WriteLine();
}
Console.WriteLine("Разница матриц");
int rowsplus = matrminus.GetUpperBound(0) + 1;
int columnsplus = matrminus.Length / rowsplus;
for(int i = 0; i < matrminus.GetLength(0); i++)
{
    for (int j = 0; j < matrminus.GetLength(1); j++)
        Console.Write("{0} ", matrminus[i, j]);
    Console.WriteLine();
}

