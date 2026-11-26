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


            Console.WriteLine($"number of copies on shelf 1, slot 0 is: {shelfCopies[1, 0]}");

            #endregion

            #region Q3 void method
            Console.WriteLine("\nQ3 void method");

            PrintWelcomeMessage();

            #endregion


            #region Q4 Void Method With Parameter

            Console.WriteLine("\nQ4 Void Method With Parameter");

            PrintBookTitle("Clean Code");


            #endregion


            #region Q5 Method returns value

            Console.WriteLine("\nQ5 Method returns value");

            int pages = 400;
            Console.WriteLine($"Pass by value: {AddBonusPages(pages)}"); // 450
            Console.WriteLine($"pages : {pages}"); //400



            #endregion


            #region Q6 Arrays as Parameters
            Console.WriteLine("\nQ6 Arrays as Parameters");
            double[] prices1 = { 25.5, 40.0 };

            Console.WriteLine($"prices[0] before method: {prices1[0]}"); //25.5
            Console.WriteLine($"===========");
            Console.WriteLine($"prices[0] after method: {prices1[0]}");  //20.5


            #endregion



            #region Q7 By ref
            Console.WriteLine("\nQ7 By ref");

            Console.WriteLine($"Pass by ref: {AddBonusPagesByRef(ref pages)}"); // 450
            Console.WriteLine($"pages : {pages}"); //450


            #endregion









            Console.ReadKey();
        }

        #region Q3 void method
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        #endregion




        #region #region Q4 Void Method With Parameter

        static void PrintBookTitle(string title)
        {

            Console.WriteLine("Book title: " + title);
        }

        #endregion


        #region Q5 Method returns value

        static int AddBonusPages(int pages)
        {
            return pages + 50;
        }


        #endregion


        #region Q6 Arrays as Parameters
        static double ApplyDiscount(double[] prices)
        {
            return prices[0] = prices[0] - 5;


        }
        #endregion


        #region Q7 Method by ref

        static int AddBonusPagesByRef(ref int pages)
        {
            pages = pages + 50;
            return pages;
        }


        #endregion


    }
}
