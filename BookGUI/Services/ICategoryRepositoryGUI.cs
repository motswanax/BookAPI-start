using BookApiProject.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookGUI.Services
{
    public interface ICategoryRepositoryGUI
    {
        CategoryDto GetCategoryById(int categoryId);
        IEnumerable<CategoryDto> GetAllCategories();
        IEnumerable<CategoryDto> GetAllCategoriesForBook(int bookId);
        IEnumerable<BookDto> GetAllBooksForCategory(int bookId);
    }
}
