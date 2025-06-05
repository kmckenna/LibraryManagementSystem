namespace LibraryManagement;

class Program
{
    // public List<Book> Books { get; set; } = new List<Book>();
    public static string book1 = "The Great Gatsby";
    public static string book2 = "To Kill a Mockingbird";
    public static string book3 = "1984";
    public static string book4 = "Pride and Prejudice";
    public static string book5 = "The Catcher in the Rye";
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // Display the options
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("=========================================");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Add a book");
            Console.WriteLine("2. Remove a book");
            Console.WriteLine("3. Display all books");
            // Console.WriteLine("4. Search for a book by title");
            // Console.WriteLine("5. Search for a book by author");
            // Console.WriteLine("6. Search for a book by ISBN");
            Console.WriteLine("99. Exit");
            Console.WriteLine("=========================================");
            Console.WriteLine();

            string input = Console.ReadLine() ?? string.Empty;

            switch (input)
            {
                case "1":
                    Console.WriteLine("Adding a book...");
                    // Add book logic here  
                    AddBook();
                    break;

                case "2":
                    Console.WriteLine("Removing a book...");
                    // Remove book logic here
                    RemoveBook();
                    break;

                case "3":
                    Console.WriteLine("Displaying all books...");
                    // Display all books logic here
                    Console.WriteLine("Books in the library:");
                    Console.WriteLine("1. " + book1);
                    Console.WriteLine("2. " + book2);
                    Console.WriteLine("3. " + book3);
                    Console.WriteLine("4. " + book4);
                    Console.WriteLine("5. " + book5);
                    break;

                case "99":
                    Console.WriteLine("Exiting the program...");
                    return; 
                    
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
    // Add more methods for searching and other functionalities as needed
    // Example method to add a book
    public static void AddBook()
    {
        Console.WriteLine("Enter book title:");
        string title = Console.ReadLine() ?? string.Empty;
        if (string.IsNullOrEmpty(title))
        {
            Console.WriteLine("Title cannot be empty.");
            return;
        }
        if (string.IsNullOrEmpty(book1))
        {
            book1 = title;
            return;
        }
        if (string.IsNullOrEmpty(book2))
        {
            book2 = title;
            return;
        }
        if (string.IsNullOrEmpty(book3))
        {
            book3 = title;
            return;
        }
        if (string.IsNullOrEmpty(book4))
        {
            book4 = title;
            return;
        }
        if (string.IsNullOrEmpty(book5))
        {
            book5 = title;
            return;
        }
        Console.WriteLine("Library is full, cannot add more books.");
    }
    // Example method to remove a book
    public static void RemoveBook()
    {
        Console.WriteLine("Enter book title to remove:");
        string title = Console.ReadLine() ?? string.Empty;
        if (title == book1)
        {
            book1 = string.Empty;
            Console.WriteLine("Book removed successfully!");
            return;
        }
        if (title == book2)
        {
            book2 = string.Empty;
            Console.WriteLine("Book removed successfully!");
            return;
        }
        if (title == book3)
        {
            book3 = string.Empty;
            Console.WriteLine("Book removed successfully!");
            return;
        }
        if (title == book4)
        {
            book4 = string.Empty;
            Console.WriteLine("Book removed successfully!");
            return;
        }
        if (title == book5)
        {
            book5 = string.Empty;
            Console.WriteLine("Book removed successfully!");
            return;
        }
        Console.WriteLine("Book not found.");
    }
}

// public class Book
// {
//     public string Title { get; set; }
//     public string Author { get; set; }
//     public string ISBN { get; set; }
// }