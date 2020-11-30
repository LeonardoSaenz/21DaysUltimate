using Deku.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Deku.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            using (var context = new NorthwindContext())
            {
                return context.Categories.ToList();
            }
        }
    }
}
