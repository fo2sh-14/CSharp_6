namespace Ass_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1st answer
            Book book_1 = new Book();
            //Console.WriteLine(book_1.password); // error 
            // Because private scope in class book only (not main)
            #endregion

            #region 2st answer
            Console.WriteLine(book_1.copiesInStock);
            // Yes compile, because field copiesInStock is internal ==> we can use in the same project 
            #endregion

            #region 3st answer
            book_1.Title = "C#";
            Console.WriteLine(book_1.Title);
            #endregion

            #region 4st answer
            Console.WriteLine(book_1.genre);
            #endregion

        }
    }
}
