using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetFinder.Data;
using PetFinder.Entities;

namespace PetFinder.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetAppUsersController : Controller
    {
        private readonly AppDbContext _context;

        public PetAppUsersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IReadOnlyList<PetAppUser>> Index()
        {
            return Ok(_context.PetUsers.ToList());
        }
        
        
        [HttpGet("{id}")]
        public ActionResult<PetAppUser> GetByID(string id)
        {
            var pet = _context.PetUsers.Find(id);

            if(pet==null)
                return NotFound();

            return Ok(pet);
        }

    
    }
}
