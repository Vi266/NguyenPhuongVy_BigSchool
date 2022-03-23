using _1911065716_NguyenPhuongVy_BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1911065716_NguyenPhuongVy_BigSchool.Controllers
{
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CourseController()
        {
            _dbContext = new ApplicationDbContext();
        }

        public List<Category> Categories { get; private set; }

        // GET: Course
        public ActionResult Create()
        {
            var viewModel = new CourseController
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View();
        }
    }
}