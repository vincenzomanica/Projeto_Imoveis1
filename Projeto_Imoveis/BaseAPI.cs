using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Imoveis
{
    public interface BaseAPI
    {
        Task<string> GetDadosAsync(string endpoint);
        Task<bool> PostDadosAsync(string endpoint, object dados);
    }
}
