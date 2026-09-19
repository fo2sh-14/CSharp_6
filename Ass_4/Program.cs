namespace Ass_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1st answer
            Book book_1 = new Book();
            Console.WriteLine(book_1.password); // error 
            // Because private scope in class book only (not main)
            #endregion

        }
    }
}
