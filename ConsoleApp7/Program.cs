
namespace ConsoleApp7
{



    class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book("Book1", 10.99, 5, "Fiction");


            Book book2 = new Book("Book2", 14.99, 3, "Non-fiction");


            Library library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);

            library.ShowAllBooks();
        }
    }

}   


