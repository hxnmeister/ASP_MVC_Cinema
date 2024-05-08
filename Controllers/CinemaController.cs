using ASP_MVC_Cinema.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ASP_MVC_Cinema.Controllers
{
    public class CinemaController : Controller
    {
        private readonly CinemaModel model = new CinemaModel();

        public IActionResult Index()
        {
            return View(model);
        }

        public IActionResult GetSessions(string id)
        {
            int currentId = int.Parse(id);
            Dictionary<DateTime, MovieModel> sessions = new Dictionary<DateTime, MovieModel>();

            foreach (var item in model.Sessions)
            {
                if (item.Value.Id == currentId)
                {
                    sessions[item.Key] = item.Value;
                }
            }

            return View(sessions?.Count > 0 ? sessions : null);
        }
    }
}
