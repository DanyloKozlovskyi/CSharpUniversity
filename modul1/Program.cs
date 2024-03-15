namespace modul1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mat = new Matrix();
            mat.FillMatrixRandom(4, 5, 0, 10);
            for (int i = 0; i < mat.row; i++)
            {
                for (int j = 0; j < mat.col; j++)
                {
                    Console.Write(mat[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < mat.row; i++)
            {
                for (int j = 0; j < mat.col; j++)
                {
                    if (mat[i, j] == 5)
                    {
                        Console.Write(mat[i, j]);
                        Console.Write(" ");
                    }
                   
                }
                Console.WriteLine();
            }
            Console.WriteLine(mat[1, 1]);
        }
    }
}