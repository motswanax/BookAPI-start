using BookApiProject.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookGUI.Services
{
    interface IReviewRepositoryGUI
    {
        IEnumerable<ReviewDto> GetAllReviews();
        ReviewDto GetReviewById(int reviewId);
        IEnumerable<ReviewDto> GetAllReviewsForBook(int bookId);
        BookDto GetBookForReview(int reviewId);
    }
}
