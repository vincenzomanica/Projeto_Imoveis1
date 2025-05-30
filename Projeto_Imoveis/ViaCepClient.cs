﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace Projeto_Imoveis
{
    public class ViaCepClient : IViaCepClient
    {
        //Cria uma instância Singleton de HttpClient usando HttpClientFactory
        private static readonly HttpClient httpClient = HttpClientFactory.Instance;
        //Método assíncrono para pesquisar o CEP
        public async Task<CEP> SearchAsync(string cep)
        {
            //Garante que a função de teste de conexão seja bem-sucedida
            if (await HttpClientFactory.TestConnectionAsync())
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
            else
            {
                return new CEP();
            }
           
        }
        //Método assincrono para pesquisar um endereço
        public async Task<List<CEP>> SearchByAddressAsync(string estado, string cidade, string logradouro)
        {
            //Garante que a função de teste de conexão seja bem-sucedida
            if (await HttpClientFactory.TestConnectionAsync())
            {
                // Envia uma solicitação GET para a API ViaCep com o endereço fornecido.
                var response = await httpClient.GetAsync($"/ws/{estado}/{cidade}/{logradouro}/json/");
                response.EnsureSuccessStatusCode();
                //Lê o conteúdo da resposta como uma string JSON
                var json = await response.Content.ReadAsStringAsync();
                //Desserializa a string JSON em uma lista de objetos CEP e a retorna
                return JsonConvert.DeserializeObject<List<CEP>>(json);
            }
            
            else
            {
                return new List<CEP>();
            }
        }
    }
}
