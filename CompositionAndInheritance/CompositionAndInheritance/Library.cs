using System.Collections.Generic;
using System;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public DateTime PublicationDate { get; set; }
}

public class Library
{
    public string LibraryName { get; set; }
    public List<Book> Books { get; set; }

    public Library()
    {
        Books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void DisplayBooks()
    {
        Console.WriteLine($"Books in {LibraryName}:");
        foreach (var book in Books)
        {
            Console.WriteLine($"{book.Title} by {book.Author}");
        }
    }
}
