namespace LibraryManagementSystem
{
    class Book
    {
        public string Title;
        public string Asuthor;
        public int ISBN;
        public bool Availability;

        public Book(string title, string asuthor, int iSBN, bool availability = true)
        {
            Title = title;
            Asuthor = asuthor;
            ISBN = iSBN;
            Availability = availability;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"The Title : {Title}");
            Console.WriteLine($"The Asuthor : {Asuthor}");
            Console.WriteLine($"The ISBN : {ISBN}");
            Console.WriteLine($"The Availability : {Availability}");
            Console.WriteLine("-------------------------------");
        }
    }
    class LaLibrary
    {
        List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("this book is added");
        }
        public bool SearchBook(string title, string asuthor)
        {
            //bool Find = false;

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title == title && books[i].Asuthor == asuthor)
                {
                    books[i].DisplayInfo();
                    return true;
                }
            }

            return false;
        }

        public void BorrowBook(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {

                if (books[i].Title == title)
                {
                    if (books[i].Availability == true)
                    {
                        books[i].Availability = false;
                        Console.WriteLine("Book Borrowed");
                    }
                    else
                    {
                        Console.WriteLine("Book Already  Borrowed");
                    }
                    return;
                }
            }

            Console.WriteLine("Book Not Found");
        }

        public void ReturnBook(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title == title)
                {
                    books[i].Availability = true;
                    Console.WriteLine("the book returned");
                }
                else
                {
                    Console.WriteLine("not returned");
                }

                return;
            }
        }

        public void DisblayAllBooks()
        {
            for (int i = 0; i < books.Count; i++)
            {
                books[i].DisplayInfo();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            LaLibrary laLibrary = new LaLibrary();


            Book b1 = new Book("java","ahmed",8888888);
            Book b2 = new Book("C","youssef",7777777);
            Book b3 = new Book("C++","shaban",4444444);
            Book b4 = new Book("C#","mohamed",6666666);

            laLibrary.AddBook(b1);
            laLibrary.AddBook(b2);
            laLibrary.AddBook(b3);
            laLibrary.AddBook(b4);

            Console.WriteLine("++++++++++++++++++++");

            Console.WriteLine("\nAll Books");
            laLibrary.DisblayAllBooks();

            Console.WriteLine("\nSearch Book:");
            laLibrary.SearchBook("C", "youssef");

            Console.WriteLine("\nBorrow Book:");
            laLibrary.BorrowBook("java");

            Console.WriteLine("All Books After Borrow");
            laLibrary.DisblayAllBooks();

            Console.WriteLine("\nReturn Book");
            laLibrary.ReturnBook("java");

            Console.WriteLine("\nAll Books After Return:");
            laLibrary.DisblayAllBooks();

        }
    }

}





