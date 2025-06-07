class LibraryManager
{
    static void Main()
    {
        string book1 = "";
        string book2 = "";
        string book3 = "";
        string book4 = "";
        string book5 = "";

        while (true)
        {
            Console.WriteLine("Would you like to add or remove a book? (add/remove/exit)");
            string action = Console.ReadLine() ?? "";

            if (string.Equals(action, "add", StringComparison.OrdinalIgnoreCase))
            {
                if (!string.IsNullOrEmpty(book1) && !string.IsNullOrEmpty(book2) && 
                    !string.IsNullOrEmpty(book3) && !string.IsNullOrEmpty(book4) && 
                    !string.IsNullOrEmpty(book5))
                {
                    Console.WriteLine("The library is full. No more books can be added.");
                    continue;
                }
            

                Console.WriteLine("Enter the title of the book to add:");
                string newBook = Console.ReadLine() ?? "";

                if (string.Equals(newBook, book1, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Book already exists in the library.");
                    continue;
                }
                if (string.Equals(newBook, book2, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Book already exists in the library.");
                    continue;
                }
                if (string.Equals(newBook, book3, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Book already exists in the library.");
                    continue;
                }
                if (string.Equals(newBook, book4, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Book already exists in the library.");
                    continue;
                }
                if (string.Equals(newBook, book5, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Book already exists in the library.");
                    continue;
                }

                if (string.IsNullOrEmpty(book1))
                {
                    book1 = newBook;
                }
                else if (string.IsNullOrEmpty(book2))
                {
                    book2 = newBook;
                }
                else if (string.IsNullOrEmpty(book3))
                {
                    book3 = newBook;
                }
                else if (string.IsNullOrEmpty(book4))
                {
                    book4 = newBook;
                }
                else if (string.IsNullOrEmpty(book5))
                {
                    book5 = newBook;
                }
      
            }
            else if (string.Equals(action, "remove", StringComparison.OrdinalIgnoreCase) && 
                     (!string.IsNullOrEmpty(book1) || !string.IsNullOrEmpty(book2) || 
                      !string.IsNullOrEmpty(book3) || !string.IsNullOrEmpty(book4) || 
                      !string.IsNullOrEmpty(book5))) 
            {
                Console.WriteLine("Enter the title of the book to remove:");
                string removeBook = Console.ReadLine() ?? "";

                if (string.Equals(removeBook, book1, StringComparison.OrdinalIgnoreCase))
                {
                    book1 = "";
                }
                else if (string.Equals(removeBook, book2, StringComparison.OrdinalIgnoreCase))
                {
                    book2 = "";
                }
                else if (string.Equals(removeBook, book3, StringComparison.OrdinalIgnoreCase))
                {
                    book3 = "";
                }
                else if (string.Equals(removeBook, book4, StringComparison.OrdinalIgnoreCase))
                {
                    book4 = "";
                }
                else if (string.Equals(removeBook, book5, StringComparison.OrdinalIgnoreCase))
                {
                    book5 = "";
                }
                else
                {
                    Console.WriteLine("Book not found.");
                }
            }
            else if (string.Equals(action, "exit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid action. Please type 'add', 'remove', or 'exit'.");
            }

            // Display the list of books
            Console.WriteLine("Available books:");
            if (!string.IsNullOrEmpty(book1)) Console.WriteLine(book1);
            if (!string.IsNullOrEmpty(book2)) Console.WriteLine(book2);
            if (!string.IsNullOrEmpty(book3)) Console.WriteLine(book3);
            if (!string.IsNullOrEmpty(book4)) Console.WriteLine(book4);
            if (!string.IsNullOrEmpty(book5)) Console.WriteLine(book5);
        }
    }
}