using Ecommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        EcommerceContext _ecommerceDbsContext;
        public CategoryController(EcommerceContext ecommerceDbsContext)
        {
            _ecommerceDbsContext = ecommerceDbsContext;
        }
        [HttpGet]
        [Route("GetAllCategories")]
        public IEnumerable<Category> GetAllCategories()
        {
            return _ecommerceDbsContext.Categories.ToList();
        }

    }
}
