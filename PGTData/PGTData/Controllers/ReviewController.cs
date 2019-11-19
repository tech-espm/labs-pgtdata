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

        [HttpGet("Historic")]
        public IActionResult GetHistoric(string StartDate, string EndDate)
        {
            try
            {
                List<HistoricResult> historic = new List<HistoricResult>();

                var reviews = _unitOfWork.Review.GetHistoric(StartDate, EndDate);

                if (reviews == null)
                {
                    return new ErrorResult("Review Not Found");
                }

                foreach (var item in reviews)
                {
                    var user = _unitOfWork.User.Get(item.UserID);
                    var group = _unitOfWork.Group.Get(user.GroupID);

                    historic.Add(new HistoricResult
                    {
                        GroupID = group.GroupID,
                        GroupName = group.GroupName,
                        ReviewID = item.ReviewID,
                        Grade = item.ReviewAccording + item.ReviewContent + item.ReviewMemorial + item.ReviewRelevance + item.ReviewResearch,
                        Date = item.ReviewDate
                    });
                };

                return new MyOkResult(historic);
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        [HttpGet("Report")]
        public IActionResult GetAll()
        {
            try
            {
                var reviews = _unitOfWork.Review.GetAll();

                return new MyOkResult(reviews);
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