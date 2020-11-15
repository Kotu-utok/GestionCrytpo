using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionCrytpo.Services.Interface
{
    public interface IObtenirPrixCrypto
    {
        public Task<string> GetPrixCryptos();
    }
}
