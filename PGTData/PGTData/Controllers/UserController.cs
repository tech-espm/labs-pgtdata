using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using PGTData.Commom.CustomResults;
using PGTData.Models;
using PGTData.Repositories;
using PGTData.Repositories.Interfaces;
using PGTData.Requests;
using PGTData.Results;

namespace PGTData.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = (UnitOfWork)unitOfWork;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                
                var obj = _unitOfWork.User.GetAll();

                if (obj == null)
                {
                    return new ErrorResult("User Not Found");
                }

                return new MyOkResult(obj.Select(x => (UserResult)x).ToList());
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        [HttpGet("{GroupID}")]
        public IActionResult GetByGroup(int GroupID)
        {
            try
            {

                var obj = _unitOfWork.User.Find(x => x.GroupID == GroupID);

                if (obj == null)
                {
                    return new ErrorResult("Users Not Found");
                }

                return new MyOkResult(obj.Select(x => (UserResult)x).ToList());
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        [HttpGet("{CampusID}")]
        public IActionResult GetByCampus(int CampusID)
        {
            try
            {

                var obj = _unitOfWork.User.Find(x => x.CampusID == CampusID);

                if (obj == null)
                {
                    return new ErrorResult("Users Not Found");
                }

                return new MyOkResult(obj.Select(x => (UserResult)x).ToList());
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        [HttpGet("Wanings")]
        public IActionResult GetWarnings(int UserID)
        {
            try
            {

                var obj = _unitOfWork.Warning.GetByUser(UserID);

                if (obj == null)
                {
                    return new ErrorResult("User Not Found");
                }

                List<WarningResult> warnings = new List<WarningResult>();

                foreach (var item in obj)
                {
                    warnings.Add((WarningResult)item);
                }

                return new MyOkResult(warnings);
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        [HttpGet("Reviews")]
        public IActionResult GetReviews(int UserID)
        {
            try
            {

                var obj = _unitOfWork.Review.GetByUser(UserID);

                if (obj == null)
                {
                    return new ErrorResult("User Not Found");
                }

                List<ReviewResult> reviews = new List<ReviewResult>();

                foreach (var item in obj)
                {
                    reviews.Add((ReviewResult)item);
                }

                return new MyOkResult(reviews);
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]UserRequest req)
        {
            try
            {
                if (req == null)
                {
                    return new ErrorResult();
                }

                UserType userType = _unitOfWork.UserType.Get(req.UserTypeID);

                User user = new User
                {
                    UserName = req.UserName,
                    UserRegister = req.UserRegister,
                    UserEmail = req.UserEmail,
                    UserPassword = req.UserPassword,
                    UserTypeID = req.UserTypeID,
                    CampusID = req.CampusID
                };

                user.UserType = userType;

                _unitOfWork.User.Add(user);
                await _unitOfWork.Complete();

                return new MyOkResult((UserResult)user);

            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }
    }
}