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
            try
            {
                _imsService = ims;
            }
            catch
            {
                throw;
            }
        }
        //private readonly Context _context;

        //public CountryController(Context context)
        //{
        //    _context = context;
        //}

        [HttpGet("GetAllCountry")]
        public async Task<List<Country>> GetAllCountry()
        {
            try
            {
                var countries = await _imsService.GetCountry();
                return countries;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        [HttpPost("AddCountry")]
        public async Task<Country> AddCountry([FromBody] Country obj)
        {
            try
            {
                await _imsService.AddCountry(obj);
                return obj;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        [HttpPut("UpdateCountry")]
        public async Task<int> UpdateCountry(int id, Country entity)
        {
            try
            {
                var result = await _imsService.UpdateCountry(id, entity);
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpDelete("DeleteCountry")]
        public async Task<int> DeleteCountry(int id)
        {
            try
            {
                var result = await _imsService.DeleteCountry(id);
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
