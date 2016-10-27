using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class BookCatalog
    {
        private Dictionary<string,Book> books;

        public BookCatalog()
        {
            books = new Dictionary<string, Book>();
        }

        public void AddBook(Book aBook)
        {
            books.Add(aBook.GetISBN(), aBook);
        }

        public void PrintAllBooks()
        {
            // Add code that can print all books in the list
            // Hint: You will need a repetition statement

            foreach(KeyValuePair <string, Book > book in books)
            {
                book.Value.GetAllInformation();

            }

        }

        public Book LookupBook(string isbn)
        {
            Book matchingBook = null;

            // Add code that will find a book (if any) in the list
            // which has a matching ISBN number. The variable matchingBook
            // should be set to this book
            // Hint: You can use isbn to lookup the book in the Dictionar

            return matchingBook;
        }
    }
}
