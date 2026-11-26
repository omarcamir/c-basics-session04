namespace CSharpBasicsSession04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 1D Array
            Console.WriteLine("\nQ1 1D Array");

            double[] prices = new double[3] { 25.5, 40.0, 33.75 };

            Console.WriteLine($"the second price is: {prices[1]}");

            #endregion


            #region Q2 2D Array
            Console.WriteLine("\nQ2 2D Array");

            int[,] shelfCopies = {
            {3, 5 },
            {1,4 }
            };


            Console.WriteLine($"number of copies on shelf 1, slot 0 is: {shelfCopies[1,0]}");

            #endregion


            Console.ReadKey();
        }
    }
}
