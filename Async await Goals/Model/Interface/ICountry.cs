using Async_await_Goals.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_await_Goals.Model.Interface
{
    public interface ICountry
    {
        Task <List<Country>> GetCountry();
        Task <int> AddCountry(Country obj);
        Task<int> UpdateCountry(int id, Country obj);
        Task<int> DeleteCountry(int id);

    }
}
