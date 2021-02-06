using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _categoryService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
      
        }
        [HttpGet("get")]

        public IActionResult Get(int categoryId)
        {
            var result = _categoryService.Get(categoryId);
            if (result.Success)
            {
            return Ok(result);
            }
            return BadRequest();
        }





    }





}
