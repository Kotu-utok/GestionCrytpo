using GestionCrytpo.Factory.Interface;
using GestionCrytpo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionCrytpo.Factory
{
    public class CryptoCurrencyModelFactory: ICryptoCurrencyModelFactory
    {
        public CryptoCurrencyModel CreateCryptoCurrencyModelObject(Task<string> objectReturnedFromApi) 
        {

            throw new NotImplementedException();
        }
    }
}
