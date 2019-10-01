﻿using PGTData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Repositories.Interfaces
{
    public interface IStudentRepository : IRepository<Student>
    {
        List<Student> GetByGroup(int GroupID);
    }
}
