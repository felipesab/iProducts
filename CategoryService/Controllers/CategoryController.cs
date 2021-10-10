using System;
using System.Collections.Generic;
using AutoMapper;
using CategoryService.Data;
using CategoryService.Dtos;
using CategoryService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CategoryService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepo _categoryRepo;
        private IMapper _mapper;

        public CategoryController(ICategoryRepo categoryRepo, IMapper mapper)
        {
            _categoryRepo = categoryRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CategoryReadDto>> GetAll()
        {
            var categories = _categoryRepo.GetAll();
            return Ok(_mapper.Map<IEnumerable<CategoryReadDto>>(categories));
        }

        [HttpGet("{id}", Name="GetById")]
        public ActionResult<CategoryReadDto> GetById(int id)
        {
            var category = _categoryRepo.GetById(id);
            return Ok(_mapper.Map<CategoryReadDto>(category));
        }

        [HttpPost]
        public ActionResult Create(CategoryCreateDto categoryDto)
        {
            try
            {
                categoryDto.CreateDate = DateTime.Now;
                var category = _mapper.Map<Category>(categoryDto);
                _categoryRepo.Create(category);

                if(_categoryRepo.SaveChanges())
                {
                    return Created($"api/category/{category.Id}", category);
                }

                return BadRequest();
            }
            catch
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database error");
            }
        }
    }
}