Console.WriteLine("Введите размерность квадратой матрицы");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапозон чисел для матриц через пробел");
string[] input = Console.ReadLine().Split(" ");
int a = Convert.ToInt32(input[0]);
int b = Convert.ToInt32(input[1]);
int[,] matex = new int[N,N];

static int zapolnenie(int a, int b, int[,] matr,int N)
{
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
    return matr[N, N];
}

static int minus(int[,] a, int[,] b, int[,] answ,int N)
{
    int rows = a.GetUpperBound(0) + 1;
    int columns = a.Length / rows;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            answ[i,j] = a[i, j] - b[i,j];
        }

    }
    return answ[N, N];
}

static int plus(int[,] a, int[,] b, int[,] answ, int N)
{
    int rows = a.GetUpperBound(0) + 1;
    int columns = a.Length / rows;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            answ[i,j] = a[i, j] + b[i,j];
        }

    }
    return answ[N,N];
}
int[,] matr1 = zapolnenie(a,b,matex,N);