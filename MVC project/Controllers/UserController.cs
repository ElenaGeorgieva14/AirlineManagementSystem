using AppService.DTOs;
using MVC_project.ViewModels;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Web;
using System.Web.Mvc;
using WcfServiceLibrary1;

namespace MVC_project.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [Authorize]
        public ActionResult Index(int? page)
        {
            
          

           List<UserVM> usersVM = new List<UserVM>();
            using (UserService.UserClient service = new UserService.UserClient())
            {
                foreach (var user in service.GetUsers())
                {
                    usersVM.Add(new UserVM(user));
                }
            }
            return View(usersVM.ToList().ToPagedList(page ?? 1, 3));
        }
        [Authorize]
        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]

        public ActionResult CreateUser(UserVM userVM)
        {
            try
            {
                using (UserService.UserClient service = new UserService.UserClient())
                {
                    UserDTO userDTO = new UserDTO
                    {

                        Username = userVM.Username,
                        Password = userVM.Password,
                        Name = userVM.Name,
                        Age = userVM.Age,
                        Job = userVM.Job,
                        BirthDate = userVM.BirthDate,
                        Salary = userVM.Salary,
                        Phone = userVM.Phone,
                        Email = userVM.Email
                    };
                    service.PostUser(userDTO);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [Authorize]
        public ActionResult Delete(int id)
        {
            using (FlightService.FlightClient flightService = new FlightService.FlightClient())
            {

                foreach (var flight in flightService.GetFlights())
                {
                    if (flight.Pilot.Id == id)
                    {
                        flightService.DeleteFlight(flight.Id);
                    }
                }
            }
            using (UserService.UserClient service = new UserService.UserClient())
            {
                service.DeleteUser(id);
            }

            return RedirectToAction("Index");
        }

        [Authorize]
        public ActionResult EditUser(int id)
        {
            UserVM userVM = new UserVM();
            using (UserService.UserClient service = new UserService.UserClient())
            {
                var userDTO = service.GetUserById(id);
                userVM = new UserVM(userDTO);
            }

            return View(userVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult EditUser(UserVM userVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (UserService.UserClient service = new UserService.UserClient())
                    {
                        UserDTO userDTO = new UserDTO
                        {
                            Id = userVM.Id,
                            Username = userVM.Username,
                            Password = userVM.Password,
                            Name = userVM.Name,
                            Age = userVM.Age,
                            Job = userVM.Job,
                            BirthDate = userVM.BirthDate,
                            Salary = userVM.Salary,
                            Phone = userVM.Phone,
                            Email = userVM.Email
                        };
                        service.UpdateUser(userDTO);
                    }
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
        [Authorize]
        public ActionResult SearchUsers(string job, int? page)
        {
            List<UserVM> usersVM = new List<UserVM>();
            using (UserService.UserClient service = new UserService.UserClient())
            {
                foreach (var user in service.GetUsersByJob(job))
                {
                    usersVM.Add(new UserVM(user));
                }
            }
            return View(usersVM.ToList().ToPagedList(page ?? 1, 4));


        }

    }
}