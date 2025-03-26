using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
namespace Projeto_Imoveis
{
    public class ViaCepClient : IViaCepClient
    {
        private static readonly HttpClient httpClient = HttpClientFactory.Instance;
        //Método assíncrono para pesquisar o CEP
        public async Task<CEP> SearchAsync(string cep)
        {
            // Envia uma solicitação GET para a API ViaCep com o CEP fornecido.
            var response = await httpClient.GetAsync($"ws/{cep}/json");
            // Garante que a resposta seja bem-sucedida.
            response.EnsureSuccessStatusCode();
            // Lê o conteúdo da resposta como uma string JSON.
            var json = await response.Content.ReadAsStringAsync();
            // Desserializa a string JSON em uma lista de objetos CEP e a retorna.
            return JsonConvert.DeserializeObject<CEP>(json);
        }
        //Método assincrono para pesquisar um endereço
        public async Task<List<CEP>> SearchByAddressAsync(string logradouro, string cidade, string estado)
        {
            // Envia uma solicitação GET para a API ViaCep com o endereço fornecido.
            var response = await httpClient.GetAsync($"{estado}/{cidade}/{logradouro}/json/");
            //garante que a resposta seja bem-sucedida
            response.EnsureSuccessStatusCode();
            //Lê o conteúdo da resposta como uma string JSON
            var json = await response.Content.ReadAsStringAsync();
            //Desserializa a string JSON em uma lista de objetos CEP e a retorna
            return JsonConvert.DeserializeObject<List<CEP>>(json);
        }
    }
}
