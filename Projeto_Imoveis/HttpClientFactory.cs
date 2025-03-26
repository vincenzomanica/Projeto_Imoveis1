using System; // Importa o namespace System, que contém classes fundamentais para o .NET Framework
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http; // Importa o namespace System.Net.Http, que contém classes para enviar solicitações HTTP e receber respostas HTTP.

namespace Projeto_Imoveis //Define o namespace do projeto, que agrupa as classes relacionadas
{
    public static class HttpClientFactory
    {
        private static readonly Lazy<HttpClient> lazyHttpClient = new Lazy<HttpClient>(() =>
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri("https://viacep.com.br/")
            };
            return client;
        });

        public static HttpClient Instance => lazyHttpClient.Value;

        // Método para testar a conexão com a API
        public static async Task<bool> TestConnectionAsync()
        {
            try
            {
                var response = await Instance.GetAsync("ws/01001000/json");
                response.EnsureSuccessStatusCode();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
    
}
