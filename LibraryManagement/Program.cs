using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public bool IsCheckedOut { get; set; }

    public Book(string title)
    {
        Title = title;
        IsCheckedOut = false;
    }

}

class LibraryManager
{
    static void Main()
    {
        List<Book> books = new List<Book>();
        const int maxBooks = 5;
        const int maxCheckedOutBooks = 3;

        while (true)
        {
            Console.WriteLine("Would you like to add, remove, search, checkout, return, or exit? (add/remove/search/checkout/return/exit)");
            string? input = Console.ReadLine();
            string action = input == null ? "" : input.ToLower();

            if (action == "add")
            {
                AddBook(books, maxBooks);

            }
            else if (action == "search")
            {
                SearchBooks(books);
            }
            else if (action == "display")
            {
                DisplayBooks(books);
            }
            else if (action == "checkout")
            {
                CheckoutBook(books, maxCheckedOutBooks);
            }
            else if (action == "return")
            {
                ReturnBook(books);
            }
            else if (action == "remove")
            {
                RemoveBook(books);
            }
            else if (action == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid action. Please type 'add', 'remove', 'search', 'checkout', 'return', or 'exit'.");
            }

            // Display the list of books
            Console.WriteLine("Available books:");
            if (books.Count == 0)
            {
                Console.WriteLine("(none)");
            }
            else
            {
                foreach (var book in books)
                {
                    Console.WriteLine($"{book.Title} {(book.IsCheckedOut ? "(Checked Out)" : "(Available)")}");
                }
            }
        }
    }
    public static void AddBook(List<Book> books, int maxBooks)
    {
        Console.WriteLine("Enter the title of the book to add:");
        string? title = Console.ReadLine();
        if (title == null)
        {
            Console.WriteLine("Invalid title. Please try again.");
            return;
        }

        if (books.Count >= maxBooks)
        {
            Console.WriteLine("The library is full. No more books can be added.");
            return;
        }
        if (string.IsNullOrWhiteSpace(title))
        {
            Console.WriteLine("Book title cannot be empty.");
            return;
        }
        if (books.Exists(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine("This book is already in the library.");
            return;
        }
        books.Add(new Book(title));
    }
    public static void RemoveBook(List<Book> books)
    {
        if (books.Count == 0)
        {
            Console.WriteLine("The library is empty. No books to remove.");
            return;
        }
        Console.WriteLine("Enter the title of the book to remove:");
        string? title = Console.ReadLine();
        if (title == null)
        {
            Console.WriteLine("Invalid title. Please try again.");
            return;
        }
        int index = books.FindIndex(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (index >= 0)
        {
            books.RemoveAt(index);
            Console.WriteLine("Book removed successfully.");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }
    public static void DisplayBooks(List<Book> books)
    {
        Console.WriteLine("Available books:");
        if (books.Count == 0)
        {
            Console.WriteLine("(none)");
        }
        else
        {
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} {(book.IsCheckedOut ? "(Checked Out)" : "(Available)")}");
            }
        }
    }
    public static void SearchBooks(List<Book> books)
    {
        if (books.Count == 0)
        {
            Console.WriteLine("The library is empty. No books to search.");
        }
        else
        {
            Console.WriteLine("Enter the title or part of the title to search:");
            string searchTerm = Console.ReadLine() ?? "";
            var results = books.FindAll(b => b.Title.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0);

            if (results.Count == 0)
            {
                Console.WriteLine("No books found matching your search.");
            }
            else
            {
                Console.WriteLine("Search results:");
                foreach (var book in results)
                {
                    Console.WriteLine($"{book.Title} {(book.IsCheckedOut ? "(Checked Out)" : "(Available)")}");
                }
            }
        }
    }
    public static void CheckoutBook(List<Book> books, int maxCheckedOutBooks)
    {
        int checkedOutCount = books.Count(b => b.IsCheckedOut);
        if (checkedOutCount >= maxCheckedOutBooks)
        {
            Console.WriteLine($"You cannot check out more than {maxCheckedOutBooks} books at a time.");
        }
        else
        {
            Console.WriteLine("Enter the title of the book to check out:");
            string checkoutTitle = Console.ReadLine() ?? "";
            var book = books.Find(b => b.Title.Equals(checkoutTitle, StringComparison.OrdinalIgnoreCase));
            if (book == null)
            {
                Console.WriteLine("Book not found.");
            }
            else if (book.IsCheckedOut)
            {
                Console.WriteLine("Book is already checked out.");
            }
            else
            {
                book.IsCheckedOut = true;
                Console.WriteLine("Book checked out.");
            }
        }
    }
    public static void ReturnBook(List<Book> books)
    {
        Console.WriteLine("Enter the title of the book to return:");
        string returnTitle = Console.ReadLine() ?? "";
        var book = books.Find(b => b.Title.Equals(returnTitle, StringComparison.OrdinalIgnoreCase));
        if (book == null)
        {
            Console.WriteLine("Book not found.");
        }
        else if (!book.IsCheckedOut)
        {
            Console.WriteLine("Book is not checked out.");
        }
        else
        {
            book.IsCheckedOut = false;
            Console.WriteLine("Book returned.");
        }
    }
}