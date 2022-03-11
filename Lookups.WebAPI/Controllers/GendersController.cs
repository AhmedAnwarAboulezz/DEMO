using Lookups.Service.FilterDto;
using Lookups.Service.Interfaces;
using Lookups.WebAPI.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lookups.WebAPI.Controllers
{
    /// <inheritdoc />
    public class GendersController : BaseController
    {
        private readonly IGenderService _genderService;
        /// <inheritdoc />
        public GendersController(IGenderService genderService)
        {
            _genderService = genderService;
        }
        /// <summary>
        /// Get all data 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var list = await _genderService.GetAll();
            return Ok(list);
        }
        /// <summary>
        /// Get all data 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetDropdownList()
        {
            var list = await _genderService.GetDropdownList();
            return Ok(list);
        }
        /// <summary>
        /// Get data by Id
        /// </summary>
        /// <param name="id">PK Column Id</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var gender = await _genderService.Get(id);
            return Ok(gender);
        }
        /// <summary>
        /// For used in another services
        /// </summary>
        /// <param name="filteringDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> GendersPredicate(GenderFilterDto filteringDto)
        {
            var list = await _genderService.GendersPredicate(filteringDto);
            return Ok(list);
        }
        /// <summary>
        /// For used in another services
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> GetGenders(List<Guid> ids)
        {
            var genders = await _genderService.GetGenders(ids);

            return Ok(genders);
        }
    }
}