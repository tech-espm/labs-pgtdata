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
    public class GroupController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public GroupController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = (UnitOfWork)unitOfWork;
        }

        [HttpGet]
        public IActionResult Get(int GroupID)
        {
            try
            {

                var obj = _unitOfWork.Group.Get(GroupID);

                if (obj == null)
                {
                    return new ErrorResult("Group Not Found");
                }

                return new MyOkResult((GroupResult)obj);
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(GroupRequest req)
        {
            try
            {
                if (req == null)
                {
                    return new ErrorResult();
                }

                List<Student> students = new List<Student>();
                foreach (var student in req.Students)
                {
                    students.Add(_unitOfWork.Student.Get(student.StudentID));
                }

                List<User> users = new List<User>();
                foreach (var user in req.Users)
                {
                    users.Add(_unitOfWork.User.Get(user.UserID));
                }

                Group group = new Group
                {
                    GroupName = req.GroupName,
                    GroupCourse = req.GroupCourse,
                };

                _unitOfWork.Group.Add(group);
                await _unitOfWork.Complete();
                
                foreach (var student in students)
                {
                    student.GroupID = group.GroupID;
                    student.Group = group;
                    _unitOfWork.Student.Add(student);
                    await _unitOfWork.Complete();
                }

                foreach (var user in users)
                {
                    user.GroupID = group.GroupID;
                    user.Group = group;
                    _unitOfWork.User.Update(user);
                    await _unitOfWork.Complete();
                }

                return new MyOkResult((GroupResult)group);

            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }
    }
}