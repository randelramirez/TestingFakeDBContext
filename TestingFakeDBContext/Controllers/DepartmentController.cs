using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestingFakeDBContext.Models;

namespace TestingFakeDBContext.Controllers
{
    public class DepartmentController : Controller
    {
        private IEmployeeContext db;

        public DepartmentController()
        {
            this.db = new EmployeeContext();
        }

        public DepartmentController(IEmployeeContext context)
        {
            this.db = context;
        }

        public ViewResult Index()
        {
            return View(db.Departments.OrderBy(d => d.Name).ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (db is IDisposable)
            {
                ((IDisposable)db).Dispose();
            }
            base.Dispose(disposing);
        }
    }
}