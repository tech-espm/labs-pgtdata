using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PGTData.Commom.CustomResults;
using PGTData.Models;
using PGTData.Repositories;
using PGTData.Repositories.Interfaces;
using PGTData.Requests;
using PGTData.Results;

namespace PGTData.Controllers
{
    [Route("api/[controller]")]
    public class ReviewController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public ReviewController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = (UnitOfWork)unitOfWork;
        }

        [HttpGet]
        public IActionResult Get(int ReviewID)
        {
            try
            {

                var obj = _unitOfWork.Review.Get(ReviewID);

                if (obj == null)
                {
                    return new ErrorResult("Group Not Found");
                }

                return new MyOkResult((ReviewResult)obj);
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(ReviewRequest req)
        {
            try
            {
                if (req == null)
                {
                    return new ErrorResult();
                }
                
                Review review = new Review
                {
                    ReviewRelevance = req.ReviewRelevance,
                    ReviewAccording = req.ReviewAccording,
                    ReviewContent = req.ReviewContent,
                    ReviewMemorial = req.ReviewMemorial,
                    ReviewResearch = req.ReviewResearch,
                    ReviewTypeID = req.ReviewTypeID,
                    ReviewDate = req.ReviewDate
                };

                foreach (var comment in req.Comments)
                {
                    _unitOfWork.Comment.Add(comment);
                }

                _unitOfWork.Review.Add(review);
                await _unitOfWork.Complete();

                return new MyOkResult((ReviewResult)review);

            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }
    }
}