using DIPattarnDemo.Models;
using DIPattarnDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DIPattarnDemo.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService service;
        public EmployeeController(IEmployeeService service)
        {
            this.service = service;
        }

        public ActionResult Index()
        {
            var model = service.GetEmployees();
            return View(model);
        }
        public ActionResult Details(int id)
        {
            var employee = service.GetEmployeeById(id);
            return View(employee);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {
                var result = service.AddEmployee(emp);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.Error = "Something went wrong";
                    return View();
                }

            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            var employee = service.GetEmployeeById(id);
            return View(employee);
        }
        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            try
            {
                var result = service.UpdateEmployee(emp);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.Error = "Something went wrong";
                    return View();
                }

            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }
        public ActionResult Delete(int id)
        {
            var employee = service.GetEmployeeById(id);
            return View(employee);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                var result = service.DeleteEmployee(id);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.Error = "Something went wrong";
                    return View();
                }

            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }
    }
}
