using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;


namespace Projeto_Imoveis
{
    public abstract class ApiServiceBase : BaseAPI //Classe abstrata que implementa a interface BaseAPI
    {
        private readonly HttpClient _httpClient;
        protected string BaseUrl { get; } //URL base da API

        //Construtor da classe, recebe a URL base da API
        public ApiServiceBase(string baseUrl)
        {
            BaseUrl = baseUrl; //Atribui a URL base da API
            _httpClient = new HttpClient(); //Instancia um objeto HttpClient
        }
        //Implementação do GET
        public async Task<string> GetDadosAsync(string endpoint)
        {
            try
            {
                string url = $"{BaseUrl}{endpoint}";
                HttpResponseMessage response = await _httpClient.GetAsync(url); //Faz uma requisição GET para a URL especificada

                //Verifica se a requisição foi bem sucedida
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync(); //Retorna o conteúdo da resposta como string
                }

                //Se a requisição não foi bem sucedida
                else
                {
                    throw new Exception($"Erro ao chamar a API: {response.StatusCode}"); //Exibe uma mensagem de erro
                }
            }
            //Trata exceções
            catch (Exception ex)
            {
                Console.WriteLine($"Erro no GET: {ex.Message}");    //Exibe uma mensagem de erro
                return null;
            }
        }
        //Implementação do POST
        async Task<bool> BaseAPI.PostDadosAsync(string endpoint, object dados)
        {
            try
            {
                string url = $"{BaseUrl}/{endpoint}";
                string json = JsonConvert.SerializeObject(dados); //Serializa um objeto em JSON
                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json"); //Cria um objeto HttpContent com o JSON serializado

                HttpResponseMessage response = await _httpClient.PostAsync(url, content); //Serializa um objeto em JSON  e envia via POST

                return response.IsSuccessStatusCode;   //Retorna se a requisição foi bem sucedida
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro no POST: {ex.Message}"); //Exibe uma mensagem de erro
                return false;
            }
        }
    }
}
