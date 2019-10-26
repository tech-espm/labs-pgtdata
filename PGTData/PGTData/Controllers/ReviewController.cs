using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
    [ApiController]
    public class ReviewController : Controller
    {
        List<Review> result = new List<Review>();
        
        [HttpGet]
        public IActionResult Get() {
            List<Review> result = new List<Review>();
            
            return new MyOkResult(result);
        }

    }
}