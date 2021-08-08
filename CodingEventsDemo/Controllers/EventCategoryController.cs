using CodingEventsDemo.Data;
using CodingEventsDemo.Models;
using CodingEventsDemo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEventsDemo.Controllers
{
    public class EventCategoryController : Controller
    {
        private EventDbContext _eventDbContext;

        public EventCategoryController(EventDbContext eventDbContext)
        {
            _eventDbContext = eventDbContext;

        }
        public IActionResult Index()
        {
            var data = _eventDbContext.EventCategories.ToList();
            return View(data);
        }

        public IActionResult Create()
        {
            AddEventCategoryViewModel addEventCategoryViewModel = new AddEventCategoryViewModel();
            return View(addEventCategoryViewModel);
        }


        [HttpPost]
        public IActionResult ProcessCreateEventCategoryForm(AddEventCategoryViewModel addEventCategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                EventCategory eventCategory = new EventCategory
                {
                    Name = addEventCategoryViewModel.Name
                };
                _eventDbContext.EventCategories.Add(eventCategory);
                _eventDbContext.SaveChanges();
                return RedirectToAction("Index", "EventCategory");
            }
            return View(addEventCategoryViewModel);
        }
    }
}
