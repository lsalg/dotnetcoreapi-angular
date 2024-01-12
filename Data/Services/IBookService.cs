using dot_net_core_ex.Data;
using System.Collections.Generic;

namespace dot_net_core_ex.Data
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        Book GetBookByID(int id);
        void UpdateBook(int id, Book newBook);
        void DeleteBook(int id);
        void AddBook(Book newBook);

    }

}
