namespace dot_net_core_ex.Data
{
    public class BookService : IBookService
    {        
        public void AddBook(Book newBook)
        {
            Data.Books.Add(newBook);
        }

        public void DeleteBook(int id)
        {
            //find book
            var book = Data.Books.FirstOrDefault(n => n.Id == id);
            Data.Books.Remove(book);
        }

        public List<Book> GetAllBooks()
        {
            return Data.Books.ToList();
        }

        public Book GetBookByID(int id)
        {
            return Data.Books.FirstOrDefault(n => n.Id == id);
        }

        public void UpdateBook(int id, Book newBook)
        {
            //get original data
            var oldBook = Data.Books.FirstOrDefault(n => n.Id == id);
            if(oldBook != null)
            {
                oldBook.Title = newBook.Title;
                oldBook.Author = newBook.Author;
                oldBook.Description = newBook.Description;
                oldBook.Rate = newBook.Rate;
                oldBook.DateStart = newBook.DateStart;
                oldBook.DateRead = newBook.DateRead;
            }
        }
    }
}