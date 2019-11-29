using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PGTData.Commom.CustomResults;
using PGTData.Repositories;
using PGTData.Repositories.Interfaces;
using PGTData.Results;

namespace PGTData.Controllers
{
    [Route("api/[controller]")]
    public class CampusController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public CampusController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = (UnitOfWork)unitOfWork;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {

                var obj = _unitOfWork.Campus.GetAll();

                if (obj == null)
                {
                    return new ErrorResult("Group Not Found");
                }

                return new MyOkResult(obj.Select(x => (CampusResult)x).ToList());
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }
    }
}