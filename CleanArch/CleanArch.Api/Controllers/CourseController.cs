using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CleanArch.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CourseViewModel courseModel)
        {
            _courseService.CreateCourse(courseModel);

            return Ok(courseModel);
        }
    }
}
