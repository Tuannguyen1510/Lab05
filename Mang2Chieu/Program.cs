internal class Program
{
    private static void Main(string[] args)
    {
        int[,] arr = new int[3, 4];

        // Sinh ngẫu nhiên gt
        for(int i=0; i< arr.GetLength(0); i++)
        {
            for(int j =0; j < arr.GetLength(1); j++)
            {
                arr[i,j] = (new Random()).Next(10,99);
            }
        }
        Console.WriteLine("In");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.WriteLine(arr[i, j]);
            }
            Console.WriteLine();
        }
    }
}