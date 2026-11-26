namespace CSharpBasicsSession04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 1D Array
            Console.WriteLine("\nQ1 1D Array");

            double[] prices = new double[3] { 25.5, 40.0, 33.75 };

            Console.WriteLine($"the second price is: ${prices[1]}");

            #endregion


            Console.ReadKey();
        }
    }
}
