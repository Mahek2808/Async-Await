using Async_await_Goals.Model.Interface;
using Async_await_Goals.Model.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_await_Goals.Model.Service
{
    public class CountryService : ICountry
    {
        private readonly Context _context;

        public CountryService(Context context)
        {
            _context = context;
        }

        public Task <List<Country>> GetCountry()
        {      
             return _context.Countries.ToListAsync();
        }

        public Task<int> AddCountry(Country entity)
        {
                _context.Countries.Add(entity);
                return _context.SaveChangesAsync();
        }
        
        
        public async Task<int> UpdateCountry(int id,Country entity)
        {
            try
            {
                var OldRec = await _context.Countries.SingleOrDefaultAsync(m => m.CountryId == id);
                if(OldRec != null)
                {
                    OldRec.CountryId = entity.CountryId;
                    OldRec.CountryName = entity.CountryName;
                    OldRec.CountryCode = entity.CountryCode;
                    OldRec.State = entity.State;
                    OldRec.CreateDate = entity.CreateDate;
                    OldRec.UpadteDate = entity.UpadteDate;
                    OldRec.UpdateBy = entity.UpdateBy;
                    OldRec.sss = entity.sss;
                }
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to Update Country.", ex);
            }
        }

        public async Task<int> DeleteCountry(int id)
        {
                var OldRec = await _context.Countries.SingleOrDefaultAsync(m => m.CountryId == id);
                _context.Countries.Remove(OldRec);
                return await _context.SaveChangesAsync();
        }
    }
}
