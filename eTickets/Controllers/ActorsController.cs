using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Data.Services.Interfaces;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsServices _service;

        public ActorsController(IActorsServices service)
        {
            _service = service;
        }
        public async Task <IActionResult> Index()
        {

            var data = await _service.GetAllAsync();
            return View(data);
        }

        //GET: Actors/Create
        public  IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));

        }

        //GET: Actors/Details

        public async Task<IActionResult> Details(int id)
        {
            var actorsDetails = await _service.GetByIdAsync(id); 

            if (actorsDetails == null)
                return View("Empty");


            return View(actorsDetails);
        }
    }
}
