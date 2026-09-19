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

            Console.WriteLine("---------------");

            #region 5st answer
            Console.WriteLine("Fiction: " + (int)Genre.Fiction);
            Console.WriteLine("NonFiction: " + (int)Genre.NonFiction);
            Console.WriteLine("Science: " + (int)Genre.Science);
            #endregion

            #region 6st answer
            int genreNumber = 1;
            Console.WriteLine((Genre)genreNumber);
            #endregion

            #region 7st answer
            Genre genre = Genre.Fiction;
            Console.WriteLine(genre.ToString());
            #endregion

        }
    }
}
