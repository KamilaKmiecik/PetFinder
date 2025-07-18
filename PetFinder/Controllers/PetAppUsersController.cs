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
        public async Task<ActionResult<IReadOnlyList<PetAppUser>>> IndexAsync()
        {
            return await _context.PetUsers.ToListAsync();
        }
        
        
        [HttpGet("{id}")]
        public async Task<ActionResult<PetAppUser>> GetByIDAsync(string id)
        {
            var pet = await _context.PetUsers.FindAsync(id);

            if(pet==null)
                return NotFound();

            return pet;
        }

    
    }
}
