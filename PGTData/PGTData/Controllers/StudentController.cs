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
    public class StudentController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public StudentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = (UnitOfWork)unitOfWork;
        }

        [HttpGet]
        public IActionResult Get(int StudentID)
        {
            try
            {

                var obj = _unitOfWork.Student.Get(StudentID);

                if (obj == null)
                {
                    return new ErrorResult("Student Not Found");
                }

                return new MyOkResult((StudentResult)obj);
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(StudentRequest req)
        {
            try
            {
                if (req == null)
                {
                    return new ErrorResult();
                }

                Group group = _unitOfWork.Group.Get(req.GroupID);

                Student student = new Student
                {
                    StudentName = req.StudentName,
                    StudentRA = req.StudentRA,
                    GroupID = req.GroupID
                };

                student.Group = group;

                _unitOfWork.Student.Add(student);
                await _unitOfWork.Complete();

                return new MyOkResult((StudentResult)student);

            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }
    }
}