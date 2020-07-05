using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarREV.Controllers.Resources;
using CarREV.Models;
using CarREV.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarREV.Controllers
{
    public class MakesController : Controller
    {
        private readonly CarREVDbContext context;
        private readonly IMapper mapper;

        public MakesController(CarREVDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await context.Makes.Include(m => m.Models).ToListAsync();
            return mapper.Map<List<Make>, List < MakeResource >> (makes);
        }
    }
}
