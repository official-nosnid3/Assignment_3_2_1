namespace Assignment_3_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 3.2.1
             * Create a 2D array to store integers and print them in matrix 
             * format with proper formatting.
             * e. g:
             * | 2 | 3 | 4 |
             * | 1 | 4 | 6 |
            */

            int[,] matrix =
            {
                { 2, 3, 4 },
                { 5, 6, 7 }
            };

            PrintMatrix(matrix);
        }

        static void PrintMatrix(int[,] Matrix)
        {
            // row-major order: rows first, then columns
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write($"| {Matrix[i, j]} ");
                }
                Console.WriteLine("|");
            }
        }
    }
}
