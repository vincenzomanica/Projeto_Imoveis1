using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;


namespace Projeto_Imoveis
{
    public class IBGEApiService : ApiServiceBase
    {
        public IBGEApiService() : base("https://servicodados.ibge.gov.br/api/v1/localidades/")
        {
            //Construtor da classe, passando a URL base da API
        }

        public async Task<List<Estado>> GetEstadosAsync() //Método que retorna uma lista de estados
        {
            string json = await GetDadosAsync("estados?orderBy=nome"); //Faz uma requisição GET para a API do IBGE e retorna uma string com o JSON
            if (json != null)
            {
                return JsonConvert.DeserializeObject<List<Estado>>(json); //Deserializa o JSON em uma lista de objetos Estado
            }
            return new List<Estado>(); //Retorna uma lista vazia
        }
        public async Task<List<Municipio>> GetMuncipioPorEstadoAsync(string ufSigla)
        {
            string json = await GetDadosAsync($"estados/{ufSigla}/municipios?orderBy=nome"); //Faz uma requisição GET para a API do IBGE e retorna uma string com o JSON
            if (json != null)
            {
                return JsonConvert.DeserializeObject<List<Municipio>>(json); //Deserializa o JSON em uma lista de objetos Municipio
            }
            return new List<Municipio>(); //Retorna uma lista vazia
        }
    }
    public class Estado
        {
            public string  Id { get; set; } //Propriedade Id do estado
            public string Nome { get; set; } //Propriedade Nome do estado
            public string Sigla { get; set; } //Propriedade Sigla do estado
        }
        public class Municipio
        {
            public string Id { get; set; } //Propriedade Id do município
            public string Nome { get; set; } //Propriedade Nome do município
        }
   
}
