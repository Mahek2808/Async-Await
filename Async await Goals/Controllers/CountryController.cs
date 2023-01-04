using Async_await_Goals.Model;
using Async_await_Goals.Model.Interface;
using Async_await_Goals.Model.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_await_Goals.Controllers
{
    [Route("api/CountryController")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        public readonly ICountry _imsService;
        public CountryController(ICountry ims)
        {
                _imsService = ims;
        }
        //private readonly Context _context;

        //public CountryController(Context context)
        //{
        //    _context = context;
        //}

        [HttpGet("GetAllCountryAsync")]
        public Task<List<Country>> GetAllCountryAsync()
        {
                return _imsService.GetCountry();
        }

        [HttpPost("AddCountryAsync")]
        public async Task<Country> AddCountryAsync([FromBody] Country obj)
        {
                await _imsService.AddCountry(obj);
                return obj;
        }

        [HttpPut("UpdateCountryAsync")]
        public Task<int> UpdateCountryAsync(int id, Country entity)
        {
            return _imsService.UpdateCountry(id, entity);
        }

        [HttpDelete("DeleteCountryAsync")]
        public async Task<int> DeleteCountryAsync(int id)
        {
            return await _imsService.DeleteCountry(id);
        }
    }
}
