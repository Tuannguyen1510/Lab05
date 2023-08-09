internal class Program
{
    static void Print2DArray(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static int SumDiagonalElements(int[,] arr)
    {
        int sum = 0;
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i == j)
                {
                    sum += arr[i, j];
                }
            }
        }

        return sum;
    }

    static void PrintSmallestElementsInColumns(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);

        for (int j = 0; j < cols; j++)
        {
            int min = arr[0, j];
            for (int i = 1; i < rows; i++)
            {
                if (arr[i, j] < min)
                {
                    min = arr[i, j];
                }
            }
            Console.WriteLine("Cột {0}: {1}", j, min);
        }
    }

    static void PrintElementsDivisibleBy7(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (arr[i, j] % 7 == 0)
                {
                    Console.Write(arr[i, j] + " ");
                }
            }
        }
        Console.WriteLine();
    }

    static int SumElementsOnBorder(int[,] arr)
    {
        int sum = 0;
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i == 0 || i == rows - 1 || j == 0 || j == cols - 1)
                {
                    sum += arr[i, j];
                }
            }
        }

        return sum;
    }

    static int[] ConvertTo1DArray(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);
        int[] arr1D = new int[rows * cols];

        int k = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                arr1D[k++] = arr[i, j];
            }
        }

        return arr1D;
    }

    static void Print1DArray(int[] arr)
    {
        foreach (var element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
    private static void Main(string[] args)
    {
        int[,] arr2D = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };

        Console.WriteLine("Mảng 2 chiều theo hàng cột:");
        Print2DArray(arr2D);

        int sumDiagonal = SumDiagonalElements(arr2D);
        Console.WriteLine("Tổng các phần tử có chỉ số hàng=chỉ số cột: " + sumDiagonal);

        Console.WriteLine("Các phần tử nhỏ nhất trên cột:");
        PrintSmallestElementsInColumns(arr2D);

        Console.WriteLine("Các phần tử chia hết cho 7:");
        PrintElementsDivisibleBy7(arr2D);

        int sumBorder = SumElementsOnBorder(arr2D);
        Console.WriteLine("Tổng các phần tử nằm trên đường viền của mảng: " + sumBorder);

        int[] arr1D = ConvertTo1DArray(arr2D);
        Console.WriteLine("Mảng 1 chiều sau khi chuyển từ mảng 2 chiều:");
        Print1DArray(arr1D);

        Array.Sort(arr1D);
        Console.WriteLine("Mảng 1 chiều sau khi sắp xếp tăng dần:");
        Print1DArray(arr1D);
    }
}

