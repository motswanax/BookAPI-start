using BookApiProject.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookGUI.Services
{
    public interface IAuthorRepositoryGUI
    {
        IEnumerable<AuthorDto> GetAllAuthors();
        AuthorDto GetAuthorById(int authorId);
        IEnumerable<BookDto> GetAllBooksByAuthor(int authorId);
        IEnumerable<AuthorDto> GetAllAuthorsForBook(int bookId);
    }
}
