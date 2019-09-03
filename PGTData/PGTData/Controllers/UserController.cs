using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using PGTData.Commom.CustomResults;
using PGTData.Repositories;
using PGTData.Repositories.Interfaces;
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

                return new MyOkResult((UserResult)obj);
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }
    }
}