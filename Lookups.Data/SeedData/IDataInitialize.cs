using Lookups.Data.Entities;
using System.Collections.Generic;

namespace Lookups.Data.SeedData
{
    public interface IDataInitialize
    {
        IEnumerable<Country> AddCountries();
      
        IEnumerable<Gender> AddGenders();
       
    }
}
