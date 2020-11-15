using GestionCrytpo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionCrytpo.Factory.Interface
{
    public interface ICryptoCurrencyModelFactory
    {
        CryptoCurrencyModel CreateCryptoCurrencyModelObject(string objectReturnedFromApi);
    }
}
