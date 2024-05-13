using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; }
    private string Author { get; set; }
    private string Content { get; set; }

    public Book(string title, string author, string content)
    {
        Title = title;
        Author = author;
        Content = content;
    }

    public void ShowInfo()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(Title);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(Author);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Content);
        Console.ResetColor();
    }

    public void ChangeAuthor(string newAuthor)
    {
        Author = newAuthor;
    }

    public void ChangeContent(string newContent)
    {
        Content = newContent;
    }
}


class Program
{
    static void Main(string[] args)
    {
        List<Book> books = new List<Book>
        {
            new Book("Book 1", "Author 1", "Content of book 1"),
            new Book("Book 2", "Author 2", "Content of book 2")
        };

        Console.WriteLine("List of Books:");
        for (int i = 0; i < books.Count; i++)
        {
            Console.WriteLine($"[{i}] {books[i].Title}");
        }

        string input;
        do
        {
            Console.WriteLine("\nEnter the index of the book you want to edit, or 'exit' to quit:");
            input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            if (!int.TryParse(input, out int index) || index < 0 || index >= books.Count)
            {
                Console.WriteLine("Invalid index. Please try again.");
                continue;
            }

            Book selectedBook = books[index];

            Console.WriteLine("What do you want to edit? (author/content)");
            string editOption = Console.ReadLine().ToLower();

            switch (editOption)
            {
                case "author":
                    Console.WriteLine("Enter new author:");
                    string newAuthor = Console.ReadLine();
                    selectedBook.ChangeAuthor(newAuthor);
                    break;
                case "content":
                    Console.WriteLine("Enter new content:");
                    string newContent = Console.ReadLine();
                    selectedBook.ChangeContent(newContent);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine("\nUpdated Book Info:");
            selectedBook.ShowInfo();

        } while (input.ToLower() != "exit");
    }
}
