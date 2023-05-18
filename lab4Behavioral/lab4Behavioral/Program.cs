using lab4Behavioral;

class Program
{
    static void Main(string[] args)
    {
        // Create a library
        var library = new Library();

        // Create users
        var user1 = new User("user1");
        var user2 = new User("user2");

        // Subscribe users to the library
        library.Subscribe(user1);
        library.Subscribe(user2);

        // Set up the chain of responsibility
        var titleValidationHandler = new TitleValidationHandler();
        var authorValidationHandler = new AuthorValidationHandler();
        titleValidationHandler.SetNextHandler(authorValidationHandler);
        library.SetValidationHandler(titleValidationHandler);

        // Add a valid book to the library
        library.AddBookToLibrary("Book");
        // Add an invalid book to the library
        library.AddBookToLibrary("Book");

        // Remove a book from the library
        library.RemoveBookFromLibrary("Book");

        Console.ReadLine();
    }
}