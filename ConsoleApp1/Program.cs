using System;
using System.Text;

namespace Assignment2
{
    class Program
    {
        static void Main()
        {
            // Question 1:
            string title = "clean code";
            string upper = title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(upper);

            // Question 2:
         
            string book1 = "Clean Code";
            string book2 = "Clean Code";
            Console.WriteLine(
                Object.ReferenceEquals(book1, book2)
            );

            // Question 3:

            StringBuilder bookList = new StringBuilder();
            bookList.Append("Book List");
            bookList.Append(" - Updated");

            Console.WriteLine(bookList);
           
            // Question 4
           
            bookList.Replace("Book List", "Library");
            Console.WriteLine(bookList);
          
            // Question 5  
            string bookTitle = "Clean Code";
            int pages = 464;
            string sentence = "Book: " + bookTitle + ", Pages: " + pages;
            Console.WriteLine(sentence);
            // Question 6


            string interpolatedSentence = $"Book: {bookTitle}, Pages: {pages}";

            Console.WriteLine(interpolatedSentence);

            
            // Question 7

            string formattedSentence = string.Format(
                "Book: {0}, Pages: {1}",
                bookTitle,
                pages
            );

            Console.WriteLine(formattedSentence);


            // Question 8
            int bookPages = 464;

            if (bookPages > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }
            
            // Question 9
            int availableBookPages = 464;
            bool isAvailable = true;
            if (availableBookPages > 300 && isAvailable == true)
            {
                Console.WriteLine("You can borrow this book");
            }

            // Question 10

            string selectedTitle = "Refactoring";
            switch (selectedTitle)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice");
                    break;

                case "Refactoring":
                    Console.WriteLine("Nice pick");
                    break;

                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }

            // Question 11

            int pagesCount = 464;

            string sizeLabel = pagesCount > 300
                ? "Long Book"
                : "Short Book";

            Console.WriteLine(sizeLabel);


            // Books Array
            string[] books = {"Clean Code","The Pragmatic Programmer", "Refactoring"};

            // Question 12

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine((i + 1) + "." + books[i]);
            }


            
            // Question 13
            int index = 0;
            while (index < books.Length)
            {
                Console.WriteLine(books[index]);

                index++;
            }


            // Question 14
            int counter = 0;

            do
            {
                Console.WriteLine("Checking book...");

                counter++;

            } while (counter < 3);


            // Question 15

            foreach (string book in books)
            {
                Console.WriteLine(book);
            }

            // Question 16
            foreach (string book in books)
            {
                if (book == "Refactoring")
                {
                    break;
                }

                Console.WriteLine(book);
            }
            // Question 17

            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer")
                {
                    continue;
                }
                Console.WriteLine(book);
            }

            // Question 18

            PrintFirstBook(books);
        }
        static void PrintFirstBook(string[] books)
        {
            if (books.Length == 0)
            {
                return;
            }

            Console.WriteLine(books[0]);
        }
    }
}
