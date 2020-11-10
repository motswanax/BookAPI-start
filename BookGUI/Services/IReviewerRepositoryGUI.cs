using BookApiProject.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookGUI.Services
{
    public interface IReviewerRepositoryGUI
    {
        IEnumerable<ReviewerDto> GetAllReviewers();
        ReviewerDto GetReviewerById(int reviewerId);
        IEnumerable<ReviewDto> GetAllReviewsByReviewer(int reviewerId);
        ReviewerDto GetReviewerForAReview(int reviewId);
    }
}
