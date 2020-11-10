using BookApiProject.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookGUI.Services
{
    public interface IBookRepositoryGUI
    {
        IEnumerable<BookDto> GetAllBooks();
        BookDto GetBookById(int bookId);
        BookDto GetBookByIsbn(string isbn);
        decimal GetBookRating(int bookId);
    }
}
