using Microsoft.AspNetCore.Mvc;
using C2210I_ASP_5_9_DatabaseFIrst.Models;
using X.PagedList;

namespace C2210I_ASP_5_9_DatabaseFIrst.Controllers
{

    public class StudentController : Controller
    {
           StudentContext _context = new StudentContext();

        public IActionResult List(string? sortBy, string? search, int? page = 1, string sortType = "ASC")
        {
            var pagesize = 3;
            var students = _context.Students.ToList();

            if (!string.IsNullOrEmpty(search))
            {
                students = students.Where(s => s.Name.Contains(search)).ToList();
            }

            

            return View(students.ToPagedList(page ?? 1, pagesize));
            ViewBag.sortBy = sortBy;
            ViewBag.search = search;
            ViewBag.sortType = sortType;
        }
    }
}
