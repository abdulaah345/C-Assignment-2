using System.Text;
using static System.Reflection.Metadata.BlobBuilder;

namespace C__Assignment_2
{
    public class Program
    {
        static string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

        static void Main(string[] args)
        {

            #region  Q1 
            string title = "clean code";
            string uppertitle = title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(uppertitle);


            #endregion
            #region  Q2 
            string s1 = "Clean Code";
            string s2 = "Clean Code";
            Console.WriteLine(ReferenceEquals(s1, s2));


            #endregion

            #region  Q3

            StringBuilder s3 = new StringBuilder();
            s3.Append("Book List");
            s3.Append(" - Updated");
            Console.WriteLine(s3);
            #endregion
            #region  Q4

            s3.Replace("Book List", "Library");
            Console.WriteLine(s3);

            #endregion

            #region  Q5

            string title2 = "Clean Code";

            int pages = 464;

            Console.WriteLine("Book: " + title2 + ", Pages: " + pages);
            #endregion

            #region  Q6

            string title3 = "Clean Code";

            int pages1 = 464;

            Console.WriteLine($"Book:{title3},Pages:{pages1}");
            #endregion


            #region  Q7

            string sentence3 = string.Format("Book:{0},pages:{1}", title3, pages1);
            Console.WriteLine(sentence3);


            #endregion

            #region  Q8
            if (pages1 > 300)
                Console.WriteLine("Long Book");
            else
            {

            }
            Console.WriteLine("Short Book");
            #endregion

            #region  Q9
            bool isAvailable = true;
            if (pages1 > 300 && isAvailable)
                Console.WriteLine("You can borrow this book");



            #endregion
            #region  Q10
            string t = "Refactoring";
            switch (t)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case " Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;

            }

            #endregion
            #region  Q11
            string h = pages1 > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(h);
            #endregion
            #region  Q12

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1},{books[i]}");
            }

            #endregion

            #region  Q13

            string[] books2 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            int x = 0;
            while (x < books.Length)
            {
                Console.WriteLine($"{books[x]}");
                x++;
            }

            #endregion


            #region  Q14
            int c = 0;
            do
            {
                Console.WriteLine($"{books[c]}");
                c++;
            } while (c < 3);

            #endregion

            #region  Q15

            foreach (var item in books)

                Console.WriteLine(item);


            #endregion
            #region  Q16
            foreach (string book in books)
            {
                if (book == "Refactoring")
                    break;
                Console.WriteLine(book);
            }


            #endregion
            #region  Q17
            foreach (string bookss in books)
            {
                if (bookss == "The Pragmatic Programmer")
                    continue;
                Console.WriteLine(bookss);
            }


            #endregion
            #region  Q18
            PrintFirstBook();
            #endregion



        }
       public static void PrintFirstBook()
        {
            if (books.Length == 0)
                return;
            Console.WriteLine(books[0]);
        }
    }
}
