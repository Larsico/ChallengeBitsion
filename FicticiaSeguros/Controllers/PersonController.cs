using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FicticiaSeguros.Core.DTOs;
using FicticiaSeguros.Core.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FicticiaSeguros.Core.Models;
using FicticiaSeguros.Core.Services;
using FicticiaSeguros.Data;
using Microsoft.AspNetCore.Authorization;
using X.PagedList;


namespace FicticiaSeguros.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;

        public PersonController(ApplicationDbContext context, IPersonService personService)
        {
            _personService = personService;
        }


        [Authorize]
        public async Task<IActionResult> Index(int? pageSize, int? page, string searchString, string sortOrder)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";

            IEnumerable<PersonsDTO> PersonList = await _personService.GetAll();

            if (!String.IsNullOrEmpty(searchString))
            {
                PersonList = PersonList.Where(s => s.Name.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    PersonList = PersonList.OrderByDescending(p => p.Name);
                    break;

                case "Date":
                    PersonList = PersonList.OrderBy(p => p.CreatedAt);
                    break;

                case "date_desc":
                    PersonList = PersonList.OrderByDescending(p => p.CreatedAt);
                    break;

                default:
                    PersonList = PersonList.OrderBy(p => p.Name);
                    break;
            }

            pageSize = (pageSize ?? 10);
            page = (page ?? 1);

            ViewBag.PageSize = pageSize;


            return View(PersonList.ToPagedList(page.Value, pageSize.Value));
        }

        [Authorize]
        public async Task<IActionResult> Details(int id)
        {

            PersonDetailsDTO pModel = await _personService.GetDetails(id);

            if (pModel == null)
            {
                return NotFound();
            }

            return View(pModel);
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

   
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PersonCreateDTO pModel)
        {
            var result = await _personService.Create(pModel);

            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {

            PersonUpdateDTO personModel = await _personService.PersonExists(id);

            if (personModel == null)
            {
                return NotFound();
            }
            return View(personModel);
        }


        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, PersonUpdateDTO pModel)
        {
            if (id != pModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _personService.Update(pModel);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonModelExists(pModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pModel);
        }

        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {

            PersonModel pModel = await _personService.GetById(id);


            if (pModel == null)
            {
                return NotFound();
            }

            return View(pModel);
        }


        [HttpPost, ActionName("Delete")]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            PersonModel pModel = await _personService.GetById(id);

            bool result = await _personService.DeletePerson(id);

            if (!result)
            {
                return BadRequest();
            }

            return RedirectToAction(nameof(Index));
        }

        private bool PersonModelExists(int id)
        {

            var result = _personService.PersonExists(id);

            if (result != null)
            {
                return true;
            }

            return false;

        }
    }
}
